using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4336;
        public const long HardContributi = 4907;
        public const long BatchWidth = 2516;
        public const long WindowSpan = 6377;
        public const string DefaultContributi = "standard-edge";

        /// <summary>Count command counter pairs that satisfy a relation.</summary>
        public static long PairCommandCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Failed,
            Synced,
            Dropped,
        }
    }
}
