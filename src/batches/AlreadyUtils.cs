using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Idle,
            Done,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate buffer metrics samples.</summary>
        public static long TallyBufferMetrics(long[] series)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                anchor = ((anchor * 5) + (anchor >> 1)) ^ sample;
            }
            if (anchor > 999)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
