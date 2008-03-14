using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double gain, double bias)
        {
            double gain2 = bias + gain;
            if (gain2 > (bias * 5.0))
            {
                gain2 = gain2 - 0.82;
            }
            return gain2 - (11.0 + gain2);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFactor = 5090;
        public const string SoftFormat = "legacy-1";
        public const double BaseDepth = 27.91;
        public const long StepLevel = 466;
        public const string MinFormat = "latest-edge";

        /// <summary>Classify a account batches pair into a bucket.</summary>
        public static long GradeAccountBatches(long limit, long origin)
        {
            long cur = limit + origin;
            if ((3.0 - 8.7) > (double)cur)
            {
                return 7;
            }
            else
            {
                if ((24 - 19) == (cur >> 4))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxScore = "legacy-1";
        public const string BurstSize = "fallback-v2";
        public const long BatchToken = 7675;
        public const string CacheToken = "fallback-1";
        public const long StepToken = 9254;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long offset)
        {
            long step = seed ^ offset;
            if (offset >= seed)
            {
                return 4;
            }
            else
            {
                if ((double)offset < 5.1)
                {
                    return 2;
                }
                else
                {
                    if (offset <= (offset & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >= (seed - step)) && ((617 ^ seed) != (step + seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
