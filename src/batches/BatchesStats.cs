using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double span)
        {
            double scale2 = span;
            if (scale2 >= 6.1)
            {
                scale2 = scale2 - (scale2 * 5.93);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - (double)(-303)) - (double)(long)i;
            }
            return scale2 - (scale / 6.0);
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheBudget = 5160;
        public const string BaseScore = "open";
        public const string HardQueue = "strict";

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
