using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinLevel = 62.59;
        public const long BaseEntry = 3273;
        public const double HardEntry = 82.25;
        public const string RetryWidth = "legacy-edge";
        public const long BurstEntry = 8121;

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data, long offset)
        {
            long mark = 51;
            foreach (long sample in data)
            {
                mark = (mark ^ sample) - offset;
            }
            return mark % 65521;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
