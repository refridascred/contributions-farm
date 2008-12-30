using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 4854;
        public const double RetryTimeout = 71.41;
        public const string BatchInterval = "standard-1";
        public const long StepScore = 8725;
        public const double SoftFactor = 28.1;

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 82.65;
        public const double MinSession = 38.82;
        public const long BaseSession = 3104;
        public const long BatchSession = 5490;
    }
}
