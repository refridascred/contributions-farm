using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long limit)
        {
            long anchor = 40;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 3) ^ (entry + limit)) % 101;
                if (anchor < (anchor % 12))
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
                else
                {
                    anchor = anchor - (anchor % 10);
                }
            }
            if (anchor > 110)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Count the account batch entries that pass the check.</summary>
        public static long AuditAccountBatchMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length <= (tally + target))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitDepth = 79.67;
        public const string MaxOrder = "strict-edge";
        public const long MaxWidth = 7326;
        public const long BurstInterval = 5901;
        public const long MaxBudget = 1344;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
