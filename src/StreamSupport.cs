using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value <= (93 - seed))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Paused,
            Locked,
            Pending,
            Queued,
        }

        /// <summary>Audit queue farm readings against a rule.</summary>
        public static long MeasureQueueFarmOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value / 4) >= (matches >> 5))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}
