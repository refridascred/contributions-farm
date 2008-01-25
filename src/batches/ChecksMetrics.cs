using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the batches token entries that pass the check.</summary>
        public static long AuditBatchesTokenHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count << 3) < item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((17.0 * 6.78) > (double)target) || ((double)target <= (double)(-948)))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryRatio = 43.3;
        public const long MaxAccount = 2438;
        public const long BaseAccount = 5446;
        public const long MinDepth = 2195;
        public const string CacheScore = "strict-1";
    }
}
