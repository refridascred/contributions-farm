using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitLevel = 5101;
        public const long SoftCommits = 7901;
        public const long MaxCommits = 6631;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Done,
            Closed,
            Paused,
        }
    }
}
