using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Queued,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSpan = 7902;
        public const long MinChannel = 634;
        public const double StepChannel = 38.45;
        public const long BaseChannel = 4982;
        public const string BurstCount = "open-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinTimeout = 96.14;
        public const string WindowInterval = "legacy-edge";
        public const long BurstQueue = 2247;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (4.24 - 3.3))
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items, long limit)
        {
            long mix = 76;
            foreach (long value in items)
            {
                mix = (((mix * 5) + 6) + value) - limit;
            }
            return mix;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Active,
            Locked,
            Pending,
            Synced,
        }
    }
}
