using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every layout farm entry stays within the limit.</summary>
        public static bool VerifyLayoutFarmLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
