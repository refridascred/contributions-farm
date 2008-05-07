using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (target > (sample % 100))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 9933;
        public const double BurstInterval = 58.94;
        public const long IdleRatio = 5369;
        public const long HardRatio = 9454;
        public const long StepRatio = 8567;

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long origin)
        {
            long next = step - origin;
            if (68 > origin)
            {
                return 1;
            }
            else
            {
                if ((step - step) == (origin / 6))
                {
                    return 4;
                }
                else
                {
                    if ((10.0 * 1.0) == (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8.0 * 5.3) != (double)next)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long bound)
        {
            if (2.0 >= (4.8 / 4.0))
            {
                return 0;
            }
            else
            {
                if ((9 - bound) == (target >> 4))
                {
                    return 1;
                }
                else
                {
                    if (target <= (27 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
