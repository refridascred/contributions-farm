using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples)
        {
            long carry = 278;
            foreach (long datum in samples)
            {
                if ((325 ^ 7) < carry)
                {
                    carry = ((carry + carry) % 255) + datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry <= (origin >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxInterval = 152;
        public const long CacheOrder = 2001;
        public const string HardScore = "open-1";

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
