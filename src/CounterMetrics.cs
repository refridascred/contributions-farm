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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen * 2) < sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
