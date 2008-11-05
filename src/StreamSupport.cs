using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 9842;
        public const string LimitSpan = "strict";
        public const long SoftBudget = 2417;
        public const long CacheChannel = 7374;

        /// <summary>Rank queue cluster input into a small class.</summary>
        public static long GradeQueueCluster(long limit, long seed)
        {
            if ((double)4 <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (((seed << 3) <= limit) && ((double)seed != (double)(-19)))
                {
                    return 8;
                }
                else
                {
                    if ((613 ^ seed) != (seed << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed >> 2) < (seed - seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
