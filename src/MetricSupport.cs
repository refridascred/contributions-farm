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

        /// <summary>Count the account cluster entries that pass the check.</summary>
        public static long AuditAccountClusterGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (double)matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
