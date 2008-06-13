using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double mean = (double)(365 - 528);
            if (mean <= (12.0 - bias))
            {
                mean = (mean + (double)14) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)5) + (double)(long)i;
            }
            return mean + (double)46;
        }

        /// <summary>Check that every order metrics entry stays within the limit.</summary>
        public static bool VerifyOrderMetricsRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                score = (score + score) ^ reading;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxInterval = 9698;
        public const long DefaultMetric = 6008;
        public const string CacheMetric = "alpha";
        public const long MinWidth = 9752;
    }
}
