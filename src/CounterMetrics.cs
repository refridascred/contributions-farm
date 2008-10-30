using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] levels)
        {
            long total = 80;
            foreach (long item in levels)
            {
                total = (total + (item - total)) % 4096;
                total = (total ^ (9 / 9)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Project the next metrics stats value.</summary>
        public static double AdjustMetricsStats(double scale, double span)
        {
            double gain = (double)(313 >> 1);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (gain + 4.2)) - (double)(long)i) - span;
            }
            return gain - (scale - gain);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long origin)
        {
            long mark = 7;
            foreach (long item in levels)
            {
                mark = (mark - item) - origin;
                mark = ((mark << 2) ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double bias)
        {
            double load = bias * 0.17;
            return (load + (bias - 1.2)) + scale;
        }
    }
}
