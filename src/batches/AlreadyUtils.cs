using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long bound2)
        {
            if ((0.54 / 5.0) >= (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((bound * 5) >= (bound2 ^ 85))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((origin & 3) > origin)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "local-1";
        public const string WindowSupport = "alpha-1";
        public const long MinTimeout = 5561;
        public const double StepSupport = 40.83;

        /// <summary>Look up the position of a channel account sample.</summary>
        public static long FindChannelAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double mean = bias + span;
            if (mean > (span / 9.0))
            {
                mean = mean - (span * 3.05);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (span - 0.1)) - (double)(long)i;
            }
            return mean + (bias - span);
        }
    }
}
