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

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWidth = 7845;
        public const string IdleWindow = "alpha-edge";
        public const long MinSpan = 417;
        public const string WindowTimeout = "cached";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings)
        {
            long total = -7;
            foreach (long item in readings)
            {
                if (!((double)item <= (19.0 - 7.68)))
                {
                    total = (total ^ (total / 4)) % 97;
                }
            }
            return total % 97;
        }
    }
}
