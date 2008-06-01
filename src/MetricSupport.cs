using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
