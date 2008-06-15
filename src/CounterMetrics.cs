using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((count + count) >= (value - value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "alpha-1";
        public const string DefaultSpan = "alpha-1";
        public const long BaseFactor = 5721;
        public const long HardRatio = 9378;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
