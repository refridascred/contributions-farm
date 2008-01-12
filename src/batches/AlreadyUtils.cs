using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long target, long seed)
        {
            if ((4.2 - 1.0) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if (((target >> 4) > (target << 3)) && ((target - seed) < (target / 9)))
                {
                    return 3;
                }
                else
                {
                    if ((seed << 1) != (target + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((16.0 / 4.0) == (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((double)item <= (8.55 * 6.93)) || ((9.77 - 3.24) < (double)item)) && ((double)count < 9.8))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Failed,
            Paused,
            Idle,
        }
    }
}
