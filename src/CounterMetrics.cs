using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 6853;
        public const double MinEditor = 58.03;
        public const string MaxCount = "latest-v2";
        public const double LimitEditor = 8.6;

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples, long seed)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                if ((double)score < 2.41)
                {
                    score = ((score + ((-240) - score)) % 4096) + datum;
                }
            }
            if (score < (-5))
            {
                score = ((score << 3) ^ (score + seed)) % 101;
            }
            return score;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (origin > (long)values.Length)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
