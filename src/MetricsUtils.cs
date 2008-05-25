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

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
