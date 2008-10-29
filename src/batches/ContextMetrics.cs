using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinDepth = "local-1";
        public const double BurstTimeout = 20.22;
        public const long WindowBatches = 3646;
        public const long SoftSize = 3918;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum >= 59)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
