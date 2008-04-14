using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long limit)
        {
            if (!((limit >> 3) < (seed + limit)))
            {
                return 1;
            }
            else
            {
                if ((32 - seed) > (seed + 556))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                if (!((5.81 / 5.0) == (double)item))
                {
                    mark = (mark - 5) % 97;
                }
            }
            if (mark < 4)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
