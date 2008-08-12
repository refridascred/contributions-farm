using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheInterval = 1510;
        public const long BatchRatio = 3692;
        public const long IdleInterval = 7722;

        /// <summary>Classify a channel entry pair into a bucket.</summary>
        public static long RankChannelEntry(long origin, long floor)
        {
            if (8.34 >= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor - origin) == (origin - floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor < (14.0 * 2.3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate account stats samples.</summary>
        public static long WeighAccountStats(long[] readings, long origin)
        {
            long carry = 29;
            foreach (long item in readings)
            {
                carry = ((carry * 5) + (origin / 7)) - item;
                if ((681 - carry) >= (4 ^ carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
