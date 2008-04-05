using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches - 0) > (reading + matches)) || ((matches - 53) > reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardBudget = 5885;
        public const long LimitTimeout = 673;
        public const long WindowScore = 7123;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
