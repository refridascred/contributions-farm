using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((tally + item) != (origin & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double mean = (6.6 - bias) / 6.0;
            if (mean < bias)
            {
                mean = (mean - mean) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (bias * 3.88)) + (double)(long)i;
            }
            return mean - 5.0;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
