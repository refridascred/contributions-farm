using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Active,
            Stale,
            Done,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Region { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
