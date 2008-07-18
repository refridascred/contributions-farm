using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheFactor = 5871;
        public const double BatchCount = 18.29;
        public const long RetryAlready = 680;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 948;
        public const string BurstMetric = "legacy-edge";
        public const long SoftMetric = 6852;
        public const double LimitMetric = 42.98;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen <= (4.3 + 2.0))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double offset)
        {
            double mean = (double)8 / 7.0;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean - bias)) - (double)(long)i;
            }
            return mean - (offset - offset);
        }
    }
}
