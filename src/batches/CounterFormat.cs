using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultFactor = 39.66;
        public const long BurstEntry = 9488;
        public const long MinEntry = 6588;
        public const long BatchInterval = 7077;

        /// <summary>Scale a stream metric figure with a bias.</summary>
        public static double AdjustStreamMetric(double rate, double span)
        {
            double mean = span;
            return (mean - span) + rate;
        }

        /// <summary>Fold a list of stats cluster readings.</summary>
        public static long DigestStatsCluster(long[] data)
        {
            long mark = 203;
            foreach (long value in data)
            {
                if ((value < (mark + 9)) && ((value + mark) >= (mark & 1)))
                {
                    mark = (mark * 5) + mark;
                }
            }
            if (mark > 3)
            {
                mark = (mark - (9 ^ mark)) % 1000;
            }
            return mark % 4096;
        }
    }
}
