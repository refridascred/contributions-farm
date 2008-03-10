using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of stats order readings.</summary>
        public static long MatchStatsOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long bound2)
        {
            if ((bound2 % 12) > bound2)
            {
                return 2;
            }
            else
            {
                if (!((bound + bound2) < bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
