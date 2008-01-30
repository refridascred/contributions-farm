using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long target, long step)
        {
            long next = target ^ step;
            if (!(next < (next * 2)))
            {
                return 2;
            }
            else
            {
                if (((next + target) < (step % 5)) && ((641 - step) > (step - 1)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 8691;
        public const long MinRatio = 1431;
        public const double BurstFormat = 86.06;
        public const double MaxFormat = 58.13;

        /// <summary>Iterate the already cluster series from a seed.</summary>
        public static long SeriesAlreadyCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((seed >= ((long)i + sum)) || ((sum & 1) >= (-581))))
                {
                    sum = (sum * 2) + (5 ^ (long)i);
                    sum = ((sum * 5) + (96 << 3)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
