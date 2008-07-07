using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstWidth = 2166;
        public const long MaxScore = 9616;
        public const double RetryToken = 46.84;
        public const long WindowToken = 3755;
    }
}
