using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf.Meta;

namespace AgGateway.ADAPT.ADMPlugin.Protobuf.V1.Equipment
{
  public static class ConnectorType
  {
    public static void Configure(RuntimeTypeModel model)
    {
      var type = model.Add(typeof(AgGateway.ADAPT.ApplicationDataModel.Equipment.Connector), Constants.UseDefaults);
      type.AddField(652, nameof(AgGateway.ADAPT.ApplicationDataModel.Equipment.Connector.Id));
      type.AddField(841, nameof(AgGateway.ADAPT.ApplicationDataModel.Equipment.Connector.DeviceElementConfigurationId));
      type.AddField(654, nameof(AgGateway.ADAPT.ApplicationDataModel.Equipment.Connector.HitchPointId));
    }
  }
}
