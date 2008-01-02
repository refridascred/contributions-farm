using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)16 <= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > (7.06 * 1.1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
