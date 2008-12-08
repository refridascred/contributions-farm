using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((datum * 3) < bound) && ((bound + 88) < (datum - (long)data.Length)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double load = (double)2;
            if (load >= (double)7)
            {
                load = (load - (double)509) - gain;
            }
            else
            {
                load = load + 7.25;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias / 8.0)) + (double)(long)i;
            }
            return load + (double)276;
        }
    }
}
