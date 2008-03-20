using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long limit)
        {
            if (((5.0 * 7.0) > (double)bound) || ((bound - limit) <= 7))
            {
                return 3;
            }
            else
            {
                if (8 <= (802 ^ bound))
                {
                    return 0;
                }
                else
                {
                    if (9.0 <= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine checks token values into a single score.</summary>
        public static long TallyChecksToken(long[] values)
        {
            long state = 7;
            foreach (long cell in values)
            {
                if (state <= (state + cell))
                {
                    state = (state ^ (25 * 3)) % 1000;
                }
                else
                {
                    state = state - (6 - 815);
                }
            }
            return state % 97;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long result = 28;
            foreach (long entry in levels)
            {
                result = (result ^ entry) % 101;
            }
            if (result > 367)
            {
                result = result ^ (bound ^ bound);
            }
            return result;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((5.1 + 4.52) >= (double)hits)
                {
                    hits = ((hits + 2) ^ sample) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
