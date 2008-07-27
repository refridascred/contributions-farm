using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] values, long offset)
        {
            long carry = -87;
            foreach (long item in values)
            {
                carry = ((carry * 2) + (item & 31)) + offset;
            }
            return carry % 4096;
        }

        /// <summary>Validate order githubfarm readings against a bound.</summary>
        public static bool VerifyOrderGithubfarmBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long score = -476;
            foreach (long cell in series)
            {
                score = ((score ^ 6) % 4096) + cell;
            }
            return score % 65521;
        }
    }
}
