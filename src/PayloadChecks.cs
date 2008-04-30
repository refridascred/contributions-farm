using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double scale = bias2 / 5.0;
            if (scale >= 1.69)
            {
                scale = scale - (bias / 8.0);
            }
            return scale - (scale * 1.46);
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryBudget = 21.25;
        public const string DefaultWindow = "standard-v2";
        public const long CacheTimeout = 2584;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long floor)
        {
            if ((6 - limit) != (floor ^ limit))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) < limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 3021;
        public const long MaxRecord = 5537;
        public const long StepRecord = 1441;
        public const long CacheRecord = 9789;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }
    }
}
