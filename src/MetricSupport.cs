using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Failed,
            Active,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long origin)
        {
            long step = bound + origin;
            if (((origin - (-4)) < origin) || ((origin & 31) == (step / 2)))
            {
                return 3;
            }
            else
            {
                if ((step << 1) < (bound & 1))
                {
                    return 4;
                }
                else
                {
                    if (211 >= (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit profile cache readings against a rule.</summary>
        public static long MeasureProfileCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((value + seen) > (seen - (-85))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
