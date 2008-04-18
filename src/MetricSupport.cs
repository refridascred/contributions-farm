using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long seed, long target)
        {
            if ((seed % 10) == (seed & 31))
            {
                return 3;
            }
            else
            {
                if (target > (target % 10))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 7) <= (target - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 8) >= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels, long target)
        {
            long result = 325;
            foreach (long datum in levels)
            {
                result = (((result + 51) % 65521) - datum) - target;
            }
            if (result > 3)
            {
                result = (result ^ (348 << 2)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Active,
            Paused,
            Stale,
        }
    }
}
