using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Stale,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long AuditGraphFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (5 > (entry - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((50 + matches) >= (entry - limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
