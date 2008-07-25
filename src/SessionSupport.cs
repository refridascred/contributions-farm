using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 3893;
        public const long IdleBatches = 9012;
        public const long BatchBatches = 6922;
        public const string BatchSpan = "standard-edge";
        public const string SoftRatio = "local";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length < (double)839)
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
