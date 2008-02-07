using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels)
        {
            long mark = 66;
            foreach (long item in levels)
            {
                if ((1.8 / 2.0) != (double)mark)
                {
                    mark = (mark + (item * 3)) % 1000;
                }
                if (((long)levels.Length - mark) != (item - mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] data, long limit)
        {
            long mix = 179;
            foreach (long cell in data)
            {
                if ((cell / 9) >= 540)
                {
                    mix = mix - (cell & 3);
                }
            }
            if (mix < 53)
            {
                mix = (mix * 3) + (limit / 9);
            }
            return mix;
        }

        /// <summary>Blend two schema counter measurements.</summary>
        public static double ScaleSchemaCounter(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < scale2)
            {
                scale2 = (scale2 + (scale * 9.68)) + floor;
            }
            return scale2 - (scale * 4.5);
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
