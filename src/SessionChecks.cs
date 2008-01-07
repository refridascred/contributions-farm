using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit context format readings against a rule.</summary>
        public static long MeasureContextFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 7) >= (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long bound, long step)
        {
            long bound2 = bound ^ step;
            if ((1.4 * 1.0) >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((bound2 - bound) > 74)
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound2) >= 0)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(bound2 > (step << 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            New,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
