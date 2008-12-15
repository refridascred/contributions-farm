using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up metric support samples.</summary>
        public static long CompareMetricSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)tally < (18.0 * 7.4)))
                {
                    tally = ((tally + 2) + reading) + target;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (11.0 > (double)floor)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
