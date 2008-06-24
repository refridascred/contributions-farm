using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Queued,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many stats farm samples are out of range.</summary>
        public static long AuditStatsFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (6.0 + 11.0))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 88.91;
        public const long LimitMetrics = 5643;
        public const long BaseMetrics = 2605;
    }
}
