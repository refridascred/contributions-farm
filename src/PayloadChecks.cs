using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }
    }
}
