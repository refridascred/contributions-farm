using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of metric tools entries.</summary>
        public static long ScoreMetricTools(long[] levels)
        {
            long state = 24;
            foreach (long cell in levels)
            {
                if ((48 << 2) == (state * 5))
                {
                    state = (((state << 2) ^ (6 << 2)) % 101) + cell;
                }
            }
            return state;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double offset)
        {
            double scale = (double)(11 << 1);
            if (scale >= scale)
            {
                scale = scale - (scale - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (gain - offset)) + (double)(long)i;
            }
            return scale + (offset * 9.0);
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long target)
        {
            if ((double)target <= (5.05 + 13.0))
            {
                return 1;
            }
            else
            {
                if ((bound / 5) > (bound << 3))
                {
                    return 4;
                }
                else
                {
                    if ((bound % 24) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (18.0 >= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowLevel = 378;
        public const long RetryContext = 8268;
        public const long CacheTimeout = 9842;
        public const string MaxContext = "open";
        public const long BaseRatio = 6706;
    }
}
