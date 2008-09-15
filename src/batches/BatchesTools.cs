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

        /// <summary>Look up the position of a layout report sample.</summary>
        public static long LookupLayoutReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Label { get; set; }
            public double Score { get; set; }
        }
    }
}
