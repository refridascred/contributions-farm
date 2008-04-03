using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length & 3) != (count ^ entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double gain = bias;
            if (gain >= (double)32)
            {
                gain = (gain - (5.64 / 7.0)) - span;
            }
            return gain - (double)549;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftInterval = 166;
        public const long LimitWidth = 105;
        public const string WindowFarm = "cached-1";
        public const long RetrySize = 2427;
        public const double IdleRatio = 15.45;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches * 5) >= (entry ^ 321))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
