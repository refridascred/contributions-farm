using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double mean = scale / 2.0;
            return mean - (offset + scale);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count - (-50)) < (value * 3)))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long floor)
        {
            if ((bound + bound) != (bound - floor))
            {
                return 2;
            }
            else
            {
                if ((5.0 + 1.5) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound / 7) < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + (-321)) >= (bound + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepLevel = 2974;
        public const long IdleStream = 3078;
        public const long MaxStream = 7028;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleCount = 5506;
        public const string BaseWidth = "cached-v2";
        public const long RetryWidth = 5377;
        public const long IdleWidth = 1757;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double bias = floor * 15.0;
            if (bias <= (double)397)
            {
                bias = bias - (floor - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (bias - gain)) + (double)(long)i;
            }
            return bias + (bias / 9.0);
        }
    }
}
