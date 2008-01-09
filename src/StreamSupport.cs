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

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (result - result)) % 4096;
                if (!(((long)i - 93) > floor))
                {
                    result = (result + (51 & 127)) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (352 - floor)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
