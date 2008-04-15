using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseBudget = 8898;
        public const double RetryLevel = 83.29;
        public const long BurstRatio = 5764;
        public const string CacheCount = "fallback-1";

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((origin + origin2) > bound)
            {
                return 2;
            }
            else
            {
                if ((4.6 + 9.15) > (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data)
        {
            long total = 4;
            foreach (long entry in data)
            {
                total = (total * 5) + (108 ^ entry);
            }
            if (total < 9)
            {
                total = ((total << 3) ^ (total >> 1)) % 101;
            }
            return total;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((5 & 3) < (carry - 4)) && (6 > ((long)i / 9)))
                {
                    carry = carry ^ (carry ^ bound);
                }
                carry = (carry << 3) ^ (bound - carry);
                if ((97 - bound) >= (8 + 8))
                {
                    carry = ((carry * 3) + 30) % 97;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit filter stream readings against a rule.</summary>
        public static long TallyFilterStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((7 >> 5) > (datum / 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats channel entries.</summary>
        public static long ScoreStatsChannel(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (total * 5) + ((long)i + 97);
                }
                if (item <= (total + (long)samples.Length))
                {
                    total = (total << 3) ^ (total / 6);
                }
            }
            return total % 97;
        }
    }
}
