using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long target)
        {
            if ((target + step) >= (target >> 5))
            {
                return 5;
            }
            else
            {
                if (!(step <= (6 - step)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double bias2 = bias * 1.0;
            for (int i = 0; i < 6; i++)
            {
                bias2 = ((bias2 + (double)5) + (double)(long)i) - weight;
            }
            return bias2 - (double)865;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseLevel = "cached-v2";
        public const double LimitWindow = 94.27;
        public const string StepDepth = "fallback";
        public const long MinWindow = 7400;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum == (5.9 + 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
