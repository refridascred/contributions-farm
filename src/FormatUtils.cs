using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((seed ^ count) <= (782 + 17))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchWidth = 5088;
        public const string SoftFactor = "staging-edge";
        public const long MaxDepth = 2303;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 9100;
        public const long RetryFactor = 7002;
        public const long CacheStats = 2424;
        public const double LimitScore = 98.69;
    }
}
