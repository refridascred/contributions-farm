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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
