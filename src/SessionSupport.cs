using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if (offset2 > 65)
            {
                return 6;
            }
            else
            {
                if (!((offset + offset2) == (offset >> 3)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + 8) > offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            Dropped,
            Retry,
        }
    }
}
