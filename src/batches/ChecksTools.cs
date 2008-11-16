using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 - (double)0) + weight;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheDepth = 1.37;
        public const long MaxFarm = 6570;
        public const long BatchCount = 8466;
        public const string LimitFarm = "standard";

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((13.0 - 7.2) < (double)acc)
                {
                    acc = ((acc * 3) + (acc * 4)) % 4096;
                    continue;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                    acc = acc - acc;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double drift = span;
            if (drift >= span)
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - (gain * 4.0);
            }
            return drift - (double)97;
        }
    }
}
