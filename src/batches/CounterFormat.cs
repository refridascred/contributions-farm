using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 6698;
        public const long HardFormat = 5300;
        public const long BurstFactor = 8753;
        public const long DefaultSpan = 3732;

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long CountContextGraphHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 2) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes tools readings.</summary>
        public static long OverlapNotesToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
