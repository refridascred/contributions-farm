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

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] values, long limit)
        {
            long mix = -740;
            foreach (long value in values)
            {
                if ((double)mix < (double)7)
                {
                    mix = ((mix ^ (mix * 5)) % 4096) + value;
                }
                else
                {
                    mix = ((mix * 5) + (mix + 68)) % 4096;
                }
                mix = mix - (long)values.Length;
                if ((double)limit <= (2.0 - 7.24))
                {
                    break;
                }
            }
            if (mix > 28)
            {
                mix = (mix + 30) % 255;
            }
            return mix;
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
