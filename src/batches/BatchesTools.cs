using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)39 != (double)(long)values.Length)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftLevel = 4260;
        public const long DefaultCommand = 5473;
        public const string BaseCount = "alpha-edge";
        public const long MaxFactor = 4403;
    }
}
