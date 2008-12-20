using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] levels)
        {
            long state = -686;
            foreach (long cell in levels)
            {
                state = (state + (cell << 3)) % 255;
                if (!((long)levels.Length >= (state << 3)))
                {
                    state = (state - (cell & 127)) % 255;
                }
                else
                {
                    state = (state * 3) + state;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of stats commits readings.</summary>
        public static long PairStatsCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count >> 4) != (count / 7))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
