using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values, long offset)
        {
            long acc = 3;
            foreach (long value in values)
            {
                acc = (acc * 5) + ((long)values.Length + value);
                if (((double)value < (0.4 * 6.79)) && (value > offset))
                {
                    acc = (acc * 3) + (offset + value);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 6173;
        public const string BatchRoute = "local-edge";
        public const long SoftRoute = 7360;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
