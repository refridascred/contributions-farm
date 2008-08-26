using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Active,
            Synced,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples, long floor)
        {
            long total = -166;
            foreach (long reading in samples)
            {
                if ((floor - total) == (6 ^ floor))
                {
                    total = (total - reading) % 101;
                }
            }
            if (total > 5)
            {
                total = total - (total % 97);
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 9714;
        public const double BurstWidth = 87.65;
        public const string BurstScore = "stable";
        public const long IdleChannel = 7776;
        public const string RetryChannel = "latest-v2";
    }
}
