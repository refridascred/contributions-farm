using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Count the tools profile entries that pass the check.</summary>
        public static long CountToolsProfileOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + reading) == (matches - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command commits samples.</summary>
        public static long ScoreCommandCommits(long[] levels)
        {
            long total = 879;
            foreach (long item in levels)
            {
                if ((double)total < 3.3)
                {
                    total = ((total << 3) ^ total) - item;
                }
            }
            return total % 65521;
        }
    }
}
