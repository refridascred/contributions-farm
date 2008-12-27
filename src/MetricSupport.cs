using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = (result << 2) ^ seed;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine metric cache values into a single score.</summary>
        public static long FoldMetricCache(long[] items, long floor)
        {
            long anchor = 424;
            foreach (long datum in items)
            {
                anchor = ((anchor * 4) + datum) % 4096;
            }
            if (anchor < 231)
            {
                anchor = (anchor - (floor & 7)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 48.45;
        public const long MinCount = 8525;
        public const long RetryBudget = 3002;
        public const long DefaultContext = 5344;
        public const long DefaultRatio = 7927;
    }
}
