using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
