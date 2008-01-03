using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((tally >> 3) < 899))
                {
                    tally = ((tally + 2) ^ cell) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long TallyBatchAccountHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item < tally) || ((tally + tally) < item))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings, long limit)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                mark = (mark * 3) + (cell / 9);
                if (((mark & 1) != (mark << 1)) && ((cell - (-14)) > (limit ^ cell)))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark + (limit - limit)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
