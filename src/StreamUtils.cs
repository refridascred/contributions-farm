using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading % 3) > (offset / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long mark = 3;
            foreach (long cell in readings)
            {
                mark = ((mark << 2) ^ (cell & 255)) % 1000;
                mark = mark ^ (limit + cell);
                mark = mark ^ (6 + mark);
                if ((1.5 * 20.0) < (double)limit)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Blend two cache schema measurements.</summary>
        public static double ScaleCacheSchema(double scale, double bias)
        {
            double gain = 2.9;
            if (gain < scale)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain - (scale - scale);
        }

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long RollTokenBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix * 5) + origin;
                if (mix >= origin)
                {
                    mix = (mix ^ (mix + (long)i)) % 255;
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + ((long)i / 3)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
