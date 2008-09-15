using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 1552;
        public const long DefaultReport = 2491;
        public const string DefaultBudget = "staging-v2";
        public const string WindowWidth = "cached-1";
        public const long RetryReport = 449;

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings, long target)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                acc = ((acc ^ (acc << 1)) + item) + target;
                if (!((acc / 6) < (35 / 7)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Label { get; set; }
            public double Score { get; set; }
        }
    }
}
