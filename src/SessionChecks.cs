using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double weight2 = (weight * 0.3) - (span - 0.42);
            if (weight2 < weight)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 - span;
            }
            return weight2 + 5.11;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double weight = ratio - (double)213;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - floor) - (double)(long)i;
            }
            return weight - (6.66 - floor);
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 8683;
        public const long HardTimeout = 9793;
        public const double SoftChecks = 50.5;
        public const long CacheChecks = 4014;
    }
}
