using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 3) ^ origin;
                long count = 283;
                if ((1.34 / 5.0) == (double)(long)i)
                {
                    total = (total + (count & 31)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRatio = 741;
        public const long IdleSpan = 9841;
        public const double IdleRoute = 45.99;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseTimeout = "cached-v2";
        public const long RetrySize = 6933;
        public const long DefaultWindow = 2224;
        public const double BaseWidth = 89.49;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
