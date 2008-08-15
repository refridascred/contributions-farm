using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long bound)
        {
            if ((origin >> 3) > (bound * 2))
            {
                return 3;
            }
            else
            {
                if ((bound & 63) >= (-9))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((149 + limit) > (step - origin))
            {
                return 0;
            }
            else
            {
                if (!((2 * 2) <= (133 ^ limit)))
                {
                    return 2;
                }
                else
                {
                    if ((limit < (limit << 2)) && ((origin + origin) > (origin / 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step >= limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
