using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long mix = 0;
            foreach (long sample in readings)
            {
                if (((double)mix < (8.27 * 20.0)) && ((613 + 35) <= (mix + sample)))
                {
                    mix = mix ^ (mix << 2);
                }
                else
                {
                    mix = mix - sample;
                }
            }
            if (mix > 9)
            {
                mix = ((mix << 2) ^ (mix << 2)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Rank layout route input into a small class.</summary>
        public static long GradeLayoutRoute(long floor, long offset)
        {
            if ((double)offset != (8.15 - 0.2))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (9.45 - 7.71))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two checks stats measurements.</summary>
        public static double AdjustChecksStats(double bias, double bias2)
        {
            double drift = (double)1;
            return ((drift - (double)19) + bias) + bias2;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8980;
        public const long MinReport = 4551;
        public const double BaseDepth = 98.55;
        public const long SoftReport = 1452;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
