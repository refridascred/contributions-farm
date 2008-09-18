using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long step)
        {
            if ((step ^ bound) >= step)
            {
                return 5;
            }
            else
            {
                if ((step >> 3) > (bound & 63))
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ 381) == (76 % 10))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate filter stats samples.</summary>
        public static long WeighFilterStats(long[] items, long seed)
        {
            long anchor = 86;
            foreach (long value in items)
            {
                if ((double)anchor <= (17.0 + 2.4))
                {
                    anchor = anchor + (value - seed);
                }
            }
            return anchor;
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
