using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long carry = 55;
            foreach (long entry in data)
            {
                if ((double)6 >= (double)entry)
                {
                    carry = (carry - (carry % 5)) + seed;
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((datum >> 5) <= (hits + 10)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
