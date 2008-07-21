using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Failed,
            Dropped,
            New,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Paused,
            Idle,
            Closed,
            Locked,
        }
    }
}
