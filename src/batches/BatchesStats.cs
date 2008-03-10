using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((8.5 - 8.99) == (double)cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCount = "cached-v2";
        public const string CacheCommand = "standard-edge";
        public const string DefaultCount = "staging-1";

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
        }
    }
}
