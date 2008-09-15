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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
