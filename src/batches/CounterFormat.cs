using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry >> 3) == (entry + entry)) && ((96 << 2) < (entry + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 8648;
        public const long BatchTimeout = 4773;
        public const long BurstReport = 7420;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
