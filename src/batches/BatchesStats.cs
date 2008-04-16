using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5849;
        public const string MaxScore = "legacy-1";
        public const string WindowDepth = "legacy-v2";
        public const long MinInterval = 9009;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((8 << 2) <= matches)
                {
                    matches = ((matches + 2) + reading) - bound;
                }
            }
            return matches;
        }
    }
}
