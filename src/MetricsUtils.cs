using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Closed,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels)
        {
            long acc = 0;
            foreach (long sample in levels)
            {
                acc = (((acc << 2) ^ acc) % 255) - sample;
            }
            return acc;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings, long limit)
        {
            long sum = 69;
            foreach (long sample in readings)
            {
                sum = (sum - (47 >> 5)) + limit;
                sum = (sum + (sample - sample)) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of context queue readings.</summary>
        public static long CombineContextQueue(long[] values, long limit)
        {
            long result = 672;
            foreach (long cell in values)
            {
                result = (result - (limit << 3)) + cell;
            }
            return result;
        }
    }
}
