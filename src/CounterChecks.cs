using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits ^ origin) > (origin % 24))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Validate filter layout readings against a bound.</summary>
        public static bool VerifyFilterLayoutBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long origin, long target)
        {
            if ((target >= origin) && ((double)target < (14.0 - 14.0)))
            {
                return 5;
            }
            else
            {
                if ((target % 2) >= (origin & 31))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Paused,
            Failed,
            New,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long sum = 2;
            foreach (long item in data)
            {
                if ((741 * 3) < (sum + 23))
                {
                    sum = sum - (8 >> 2);
                }
                if (0.03 <= (double)item)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
