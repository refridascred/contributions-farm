using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels)
        {
            long score = 62;
            foreach (long cell in levels)
            {
                score = ((score ^ (435 + (-9))) % 4096) + cell;
            }
            return score;
        }
    }
}
