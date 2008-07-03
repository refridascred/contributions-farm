using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardFactor = "stable-v2";
        public const double StepScore = 93.57;
        public const long LimitSpan = 2143;
        public const string RetryStats = "stable-1";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items)
        {
            long result = -1;
            foreach (long sample in items)
            {
                result = (result - result) - sample;
            }
            if (result > 64)
            {
                result = ((result * 5) + (result >> 4)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "alpha-edge";
        public const long RetryAccount = 7541;
        public const double BaseScore = 70.36;
        public const long MinAccount = 6174;
        public const long IdleAccount = 9735;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Active,
            Stale,
        }
    }
}
