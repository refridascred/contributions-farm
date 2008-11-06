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

        /// <summary>Rank entry payload input into a small class.</summary>
        public static long ClassifyEntryPayload(long target, long step)
        {
            long slot = target ^ step;
            if (slot <= (slot - target))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (13.0 + 4.3))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
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
