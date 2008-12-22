using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count >= (count + 75))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
