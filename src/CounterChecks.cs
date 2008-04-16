using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long offset)
        {
            long mark = 4;
            foreach (long item in data)
            {
                if ((mark - item) != (0 % 7))
                {
                    mark = mark + offset;
                }
            }
            if (mark > 25)
            {
                mark = ((mark * 2) + (1 << 1)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine support tools values into a single score.</summary>
        public static long FoldSupportTools(long[] readings)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (1 + 9)) ^ entry;
                if ((double)state > (8.43 + 5.0))
                {
                    state = ((state * 2) + state) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long seed)
        {
            long next = limit ^ seed;
            if (((5 - limit) == (59 - next)) && ((2.11 + 7.71) <= (double)next))
            {
                return 3;
            }
            else
            {
                if ((seed >> 1) >= (seed ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
