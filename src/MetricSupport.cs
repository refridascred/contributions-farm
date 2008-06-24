using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate batches commits readings against a bound.</summary>
        public static bool ValidateBatchesCommitsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((9.9 / 5.0) >= (double)step)
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Done,
            New,
            Retry,
        }
    }
}
