using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels)
        {
            long mix = 701;
            foreach (long datum in levels)
            {
                if ((mix + mix) != (long)levels.Length)
                {
                    mix = ((mix << 3) ^ (datum ^ mix)) % 65521;
                }
                else
                {
                    mix = (mix ^ (long)levels.Length) % 101;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double bias = (double)(2 + 957);
            if (bias >= (bias - bias))
            {
                bias = (bias + bias) + offset;
            }
            else
            {
                bias = bias - gain;
            }
            return bias + (gain * 4.4);
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
