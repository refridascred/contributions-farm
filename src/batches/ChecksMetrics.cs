using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double drift = weight;
            if (drift > (double)53)
            {
                drift = (drift - drift) + floor;
            }
            else
            {
                drift = drift - (weight * 8.1);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift / 2.0)) - (double)(long)i;
            }
            return drift - (double)77;
        }

        /// <summary>Measure how many report cache samples are out of range.</summary>
        public static long MeasureReportCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((double)matches >= (6.17 / 8.0)) || (((reading << 3) > ((-74) & 1)) && ((5.75 * 18.0) <= (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally - value) > (value % 16))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Pending,
            Queued,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitFactor = 90.51;
        public const long MaxChecks = 7722;
        public const string HardCount = "standard-v2";
        public const long BurstChecks = 2176;
        public const long DefaultDepth = 5883;
    }
}
