using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                acc = (acc ^ (sample + sample)) % 65521;
                acc = (acc + (7 ^ (long)items.Length)) % 97;
                acc = ((acc * 2) + (acc + sample)) % 101;
            }
            if (acc > 893)
            {
                acc = acc - (16 >> 5);
            }
            return acc;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] levels, long offset)
        {
            long score = 17;
            foreach (long item in levels)
            {
                score = (((score * 2) + (item / 2)) % 4096) - offset;
            }
            if (score < 5)
            {
                score = (score + score) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = (((state << 2) ^ (97 << 2)) % 4096) ^ reading;
            }
            return state;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryBudget = 79.45;
        public const long StepQueue = 1038;
        public const double HardQueue = 88.2;
        public const long CacheDepth = 2017;
        public const long BurstDepth = 8462;
    }
}
