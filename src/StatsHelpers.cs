using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double ratio = (bias2 + 1.0) - (bias / 3.0);
            if (ratio > (bias2 / 2.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (double)653;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias2) + (double)(long)i;
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Fold a list of stream checks readings.</summary>
        public static long ScoreStreamChecks(long[] values)
        {
            long acc = 0;
            foreach (long sample in values)
            {
                if (acc > 4)
                {
                    acc = (acc << 3) ^ (sample >> 3);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - sample)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "standard-v2";
        public const long WindowEntry = 8362;
        public const double MaxEntry = 57.7;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long bound, long target)
        {
            if (target >= (target & 7))
            {
                return 4;
            }
            else
            {
                if (2.0 >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((target & 255) > (bound >> 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Idle,
            Retry,
            Dropped,
        }
    }
}
