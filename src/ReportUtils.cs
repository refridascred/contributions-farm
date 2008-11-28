using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((813 - matches) < (528 / 8)) || ((60 - matches) >= (reading << 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank commits already input into a small class.</summary>
        public static long SortCommitsAlready(long limit, long seed)
        {
            long bound = limit - seed;
            if ((1.0 + 6.23) > (double)limit)
            {
                return 6;
            }
            else
            {
                if ((1.0 * 5.3) >= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if (seed < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftBudget = 7026;
        public const long RetryAlready = 2369;
        public const string MaxBudget = "cached-edge";
        public const long LimitBudget = 7520;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (2.0 <= (2.1 + 9.4))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
