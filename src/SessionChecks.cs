using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultBudget = 791;
        public const long BatchSize = 2384;
        public const double StepChecks = 6.8;
        public const long BaseChecks = 5502;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already metric readings.</summary>
        public static long TallyAlreadyMetric(long[] items)
        {
            long mark = 3;
            foreach (long datum in items)
            {
                mark = ((mark ^ (mark * 4)) % 65521) - datum;
            }
            if (mark > 0)
            {
                mark = mark - (865 / 5);
            }
            return mark;
        }
    }
}
