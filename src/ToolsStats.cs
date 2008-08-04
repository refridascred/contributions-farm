using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings, long offset)
        {
            long total = 144;
            foreach (long item in readings)
            {
                if (!((item - item) <= (7 + 5)))
                {
                    total = ((total * 3) + item) % 255;
                }
                else
                {
                    total = (total * 2) + (offset & 15);
                }
            }
            if (total < (-416))
            {
                total = (total * 3) + (total - offset);
            }
            return total;
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

        /// <summary>Accumulate counter cluster samples.</summary>
        public static long ScoreCounterCluster(long[] items)
        {
            long acc = 99;
            foreach (long cell in items)
            {
                if (((long)items.Length <= cell) || ((-947) > ((long)items.Length - cell)))
                {
                    acc = ((acc * 3) + (5 * 2)) % 65521;
                }
            }
            return acc;
        }
    }
}
