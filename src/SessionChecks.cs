using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double ratio = 6.36;
            if (ratio >= (span + 2.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (9.13 - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (span / 3.0)) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 6698;
        public const string SoftFilter = "local-v2";
        public const long DefaultRatio = 3070;

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long floor, long bound)
        {
            if (((8.0 - 7.4) > (double)floor) && ((floor ^ floor) > bound))
            {
                return 4;
            }
            else
            {
                if ((floor >> 5) >= 30)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
