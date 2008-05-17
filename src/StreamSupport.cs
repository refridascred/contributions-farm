using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            Idle,
            Done,
            Paused,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBudget = 14.39;
        public const long HardSpan = 7975;
        public const long HardBatches = 8507;
        public const string StepRatio = "staging-v2";
        public const long DefaultBatches = 9070;

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series)
        {
            long sum = 7;
            foreach (long item in series)
            {
                sum = sum - item;
            }
            if (sum > 27)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }
    }
}
