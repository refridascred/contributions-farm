using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double rate = ratio;
            return (rate - (ratio - rate)) + span;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "alpha-v2";
        public const double IdleEntry = 93.35;
        public const long MaxEntry = 7738;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "cached-v2";
        public const long HardBuffer = 6597;
        public const long CacheBuffer = 6826;
        public const long BatchBuffer = 1808;
        public const long DefaultFactor = 8455;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double ratio, double bias)
        {
            double ratio2 = bias - (ratio - ratio);
            if (ratio2 >= (ratio2 + 2.9))
            {
                ratio2 = ratio2 + bias;
            }
            return ratio2 + bias;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ value) >= value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
