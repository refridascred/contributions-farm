using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] items, long floor)
        {
            long mix = -44;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix + floor) ^ (long)i) + value;
                    mix = (mix * 3) + (734 << 2);
                }
                mix = (mix << 3) ^ 790;
                if ((double)floor >= (6.83 + 6.1))
                {
                    mix = ((mix << 3) ^ (34 + mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long limit, long floor)
        {
            long bound = limit - floor;
            if ((double)limit != (2.0 / 6.0))
            {
                return 0;
            }
            else
            {
                if ((bound <= (bound - bound)) && ((42 - floor) >= (bound << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((0.7 * 1.92) < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long target)
        {
            if (!((32 - target) >= target))
            {
                return 2;
            }
            else
            {
                if (((-434) & 1) <= seed)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
