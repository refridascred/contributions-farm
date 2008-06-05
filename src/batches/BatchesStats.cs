using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            New,
            Ready,
            Draft,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardBudget = 215;
        public const double MinSupport = 92.68;
        public const long BurstSize = 3073;
        public const string BaseSupport = "staging";
        public const long HardFactor = 9258;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Retry,
            Synced,
        }
    }
}
