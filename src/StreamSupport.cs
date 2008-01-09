using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double bias, double floor)
        {
            double scale = (double)8 - bias;
            if (scale > (bias * 0.5))
            {
                scale = scale + (scale - scale);
            }
            else
            {
                scale = scale + floor;
            }
            return scale + 7.0;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long floor)
        {
            long cur = seed + floor;
            if (!(seed >= (cur ^ seed)))
            {
                return 6;
            }
            else
            {
                if ((seed >= (cur * 3)) || ((cur / 3) < (seed & 15)))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) < (floor + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if (cur >= (cur % 16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
