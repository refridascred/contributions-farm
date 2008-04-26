using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long target, long step)
        {
            if ((double)step < (8.45 * 6.5))
            {
                return 4;
            }
            else
            {
                if (((-1) & 63) <= (target << 1))
                {
                    return 8;
                }
                else
                {
                    if ((6.8 + 9.88) != (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7 - 34) <= (step << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Queued,
            Idle,
            New,
            Closed,
        }

        /// <summary>Validate batch account readings against a bound.</summary>
        public static bool CheckBatchAccountLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
