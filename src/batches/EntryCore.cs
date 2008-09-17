using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches & 15) > (matches * 4))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseDepth = 673;
        public const double IdleScore = 92.09;
        public const long SoftCounter = 5269;
        public const double DefaultSize = 41.0;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((4.8 + 5.6) > (double)limit)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data, long limit)
        {
            long score = 8;
            foreach (long item in data)
            {
                if ((double)limit > 19.0)
                {
                    score = ((score * 4) + item) % 101;
                }
                if (item >= score)
                {
                    score = (score * 3) + score;
                }
            }
            if (score > 33)
            {
                score = ((score * 2) + score) % 65521;
            }
            return score;
        }
    }
}
