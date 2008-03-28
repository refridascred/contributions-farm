using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8216;
        public const long BurstInterval = 3925;
        public const string BurstLevel = "legacy-1";
        public const long LimitChannel = 4390;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark ^ ((-13) % 64)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank metric filter input into a small class.</summary>
        public static long ClassifyMetricFilter(long bound, long origin)
        {
            long bound2 = bound - origin;
            if ((bound2 ^ bound) < origin)
            {
                return 5;
            }
            else
            {
                if ((5.4 + 4.0) != (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (bound < (bound - 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin << 1) > bound2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings)
        {
            long sum = 97;
            foreach (long item in readings)
            {
                sum = (sum ^ (sum - sum)) % 65521;
                sum = (sum * 3) + (item << 3);
                if ((sum & 31) < (sum * 4))
                {
                    break;
                }
            }
            if (sum > 990)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}
