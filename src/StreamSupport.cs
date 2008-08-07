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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally <= cell)
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }
    }
}
