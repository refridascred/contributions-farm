using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 6221;
        public const double SoftAlready = 39.23;
        public const double DefaultInterval = 50.32;
        public const string CacheLevel = "local-edge";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((3.5 / 5.0) >= (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Ready,
            Active,
        }
    }
}
