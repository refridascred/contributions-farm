using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitLevel = 1836;
        public const long CacheEditor = 6429;
        public const long SoftEditor = 503;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (94 < sample)
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                anchor = (anchor ^ 623) % 101;
                anchor = (anchor - (datum + anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (seed ^ carry)) % 97;
                if (!(6 <= carry))
                {
                    carry = carry + (seed + carry);
                }
                else
                {
                    carry = carry + (carry - 0);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
