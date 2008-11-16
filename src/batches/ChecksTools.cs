using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
