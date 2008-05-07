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

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Ready,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
