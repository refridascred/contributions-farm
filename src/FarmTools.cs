using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < (double)16)
            {
                scale = (scale + (scale * 9.0)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + bias2) + (double)(long)i;
            }
            return scale - (double)81;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((item * 5) > (hits + item)) || ((5 & 3) >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
