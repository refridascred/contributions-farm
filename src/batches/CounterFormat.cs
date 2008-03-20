using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Iterate the cache editor series from a seed.</summary>
        public static long DeriveCacheEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - (step * 5)) % 97;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
