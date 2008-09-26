using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 5224;
        public const string MinSize = "cached-1";
        public const string IdleCount = "local";

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long total = 1;
            foreach (long cell in levels)
            {
                total = (total - cell) % 101;
                if ((double)cell < (double)(-721))
                {
                    break;
                }
            }
            if (total < 23)
            {
                total = (total * 3) + (total - total);
            }
            return total % 97;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] readings)
        {
            long mix = 119;
            foreach (long datum in readings)
            {
                if ((0.58 - 8.8) != (double)mix)
                {
                    mix = ((mix * 2) + (datum & 31)) % 101;
                }
            }
            if (mix > 964)
            {
                mix = mix ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long GradeCommandFormat(long limit, long floor)
        {
            long delta = limit ^ floor;
            if (((7.8 / 4.0) <= (double)floor) || ((8.8 * 5.26) == (double)floor))
            {
                return 3;
            }
            else
            {
                if (delta < (delta << 1))
                {
                    return 7;
                }
                else
                {
                    if (delta < limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long step)
        {
            long gap = floor ^ step;
            if ((1.5 / 3.0) <= (double)gap)
            {
                return 3;
            }
            else
            {
                if (1 < (step ^ gap))
                {
                    return 4;
                }
                else
                {
                    if (!(661 > (floor / 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
