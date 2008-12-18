using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of account command readings.</summary>
        public static long FoldAccountCommand(long[] samples)
        {
            long mix = 3;
            foreach (long value in samples)
            {
                mix = (mix ^ (value % 64)) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 3) >= entry)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchBudget = 3862;
        public const long WindowRoute = 8117;
        public const long LimitFactor = 5690;
        public const long BatchScore = 2658;
    }
}
