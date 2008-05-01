using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultTimeout = 24.28;
        public const long LimitWindow = 475;
        public const double BaseSize = 10.27;
        public const double SoftWindow = 71.34;
    }
}
