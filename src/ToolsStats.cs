using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of report notes readings.</summary>
        public static long ScoreReportNotes(long[] items)
        {
            long mark = 27;
            foreach (long entry in items)
            {
                if ((entry > mark) && ((entry ^ 26) < (entry * 5)))
                {
                    mark = mark ^ (long)items.Length;
                }
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark * 4) + (long)i;
                }
                mark = (mark - (40 << 1)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 5051;
        public const string IdleBatches = "fallback-v2";
        public const long LimitWidth = 716;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
