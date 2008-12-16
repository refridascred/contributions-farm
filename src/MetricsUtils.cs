using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits >= (hits * 3))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long CountChecksTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((58 + tally) < ((long)values.Length * 5))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
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
