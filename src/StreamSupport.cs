using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 8697;
        public const long BatchCount = 173;
        public const long IdleQueue = 8933;
        public const double BurstQueue = 12.85;

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long step)
        {
            long gap = seed + step;
            if (seed > (gap - step))
            {
                return 5;
            }
            else
            {
                if ((gap < (gap & 3)) || ((2.0 - 8.2) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    if (gap > ((-814) * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + seed) != (step + seed)) || ((seed % 7) >= (seed - seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a already profile sample.</summary>
        public static long FindAlreadyProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
