using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitLevel = 6033;
        public const double CacheBudget = 32.29;
        public const double SoftCount = 91.68;
        public const string MinCache = "legacy-v2";
        public const string WindowCache = "staging-1";

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Idle,
            Stale,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally >= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((7.99 >= (double)matches) && ((2.0 / 9.0) >= (double)77))
                {
                    matches = ((matches + 1) + cell) + limit;
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long limit)
        {
            if ((origin << 2) == (origin + limit))
            {
                return 6;
            }
            else
            {
                if (origin > (2 / 6))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (925 - 46))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
