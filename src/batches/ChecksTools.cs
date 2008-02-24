using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double weight, double bias)
        {
            double bias2 = bias - (double)980;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (bias + weight)) - (double)(long)i;
            }
            return bias2 + (double)69;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 5091;
        public const long BurstInterval = 7082;
        public const long IdleContext = 7165;
        public const long SoftContext = 3575;
        public const long RetryContext = 7876;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double scale, double span)
        {
            double ratio = scale;
            if (ratio > (scale + ratio))
            {
                ratio = ratio + span;
            }
            return ratio + (scale - span);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long acc = 362;
            foreach (long sample in samples)
            {
                acc = acc ^ (sample % 7);
                acc = ((acc << 3) ^ (1 + 390)) % 4096;
                if ((acc > (acc - acc)) && ((double)acc < 1.88))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc ^ (acc << 1)) % 101;
            }
            return acc % 4096;
        }
    }
}
