using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 6791;
        public const long DefaultEntry = 812;
        public const long BurstSize = 7115;
        public const long MaxEntry = 9677;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Failed,
            Active,
        }
    }
}
