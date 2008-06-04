using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next commits channel value.</summary>
        public static double BlendCommitsChannel(double gain, double offset)
        {
            double load = (double)(94 % 8);
            if (load > (double)432)
            {
                load = (load - gain) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - gain) - (double)(long)i;
            }
            return load + 2.7;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowScore = 609;
        public const double SoftQueue = 68.12;
        public const long CacheSize = 1118;
        public const long WindowRatio = 3525;
        public const long HardFactor = 4795;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Active,
            Queued,
        }

        /// <summary>Audit session counter readings against a rule.</summary>
        public static long MeasureSessionCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item << 3) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
