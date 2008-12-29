using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSpan = 9716;
        public const long RetryEditor = 2129;
        public const long MinCount = 3888;
        public const long StepEditor = 5843;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
