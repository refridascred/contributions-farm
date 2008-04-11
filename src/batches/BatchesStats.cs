using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long floor)
        {
            long carry = 36;
            foreach (long datum in levels)
            {
                if (!(floor < (datum + floor)))
                {
                    carry = (carry << 2) ^ (carry * 3);
                }
                carry = (carry - (datum >> 3)) % 255;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 7833;
        public const long RetryTimeout = 9276;
        public const string SoftCluster = "standard";

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
