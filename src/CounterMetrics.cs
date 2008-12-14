using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (2 - seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit githubfarm format readings against a rule.</summary>
        public static long CountGithubfarmFormatOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((entry << 1) > (origin >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
