using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next record report value from a seed.</summary>
        public static long DeriveRecordReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item - tally) > (tally % 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
