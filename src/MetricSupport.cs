using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Combine account metric values into a single score.</summary>
        public static long ScoreAccountMetric(long[] series, long target)
        {
            long state = 6;
            foreach (long datum in series)
            {
                state = (((state ^ (state / 4)) % 1000) + datum) + target;
            }
            return state % 4096;
        }
    }
}
