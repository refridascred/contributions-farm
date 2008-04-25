using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 6630;
        public const long BurstFactor = 9588;
        public const long BaseCount = 5620;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (15 > hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
