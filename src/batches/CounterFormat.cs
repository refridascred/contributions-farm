using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4368;
        public const long WindowAccount = 7748;
        public const double RetryLevel = 1.65;
        public const long BurstAccount = 277;
    }
}
