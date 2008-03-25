using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two commits metric measurements.</summary>
        public static double SmoothCommitsMetric(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (gain - gain))
            {
                gain = gain - (bias - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)82) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long target, long seed)
        {
            long delta = target ^ seed;
            if ((seed * 5) < (delta + delta))
            {
                return 8;
            }
            else
            {
                if ((869 >> 5) == (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (target >= (delta - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 7445;
        public const string LimitStats = "stable-1";
        public const long StepStats = 9557;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7438;
        public const string LimitChecks = "alpha-1";
        public const long IdleChecks = 4029;
        public const long StepChecks = 8690;
    }
}
