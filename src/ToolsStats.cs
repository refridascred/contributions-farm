using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)1) + span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftFactor = 3566;
        public const long DefaultFactor = 4476;
        public const long CacheSpan = 9494;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up cache support samples.</summary>
        public static long CompareCacheSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
