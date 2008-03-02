using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long TallyCommitsPayloadOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((5 + step) >= (hits - hits))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Active,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series, long target)
        {
            long carry = 92;
            foreach (long reading in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ reading) % 1000) ^ (long)i;
                }
                if (!((1.0 * 4.0) <= (double)target))
                {
                    carry = carry - target;
                }
                else
                {
                    carry = (carry + reading) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long FoldGithubfarmChecks(long[] readings)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                anchor = ((anchor << 3) ^ 31) + item;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 889;
        public const double BurstTools = 94.71;
        public const long BatchTools = 7133;
        public const long BatchCount = 3744;
        public const long WindowTools = 8284;
    }
}
