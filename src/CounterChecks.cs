using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of queue account readings.</summary>
        public static long MatchQueueAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 8260;
        public const long StepLevel = 1485;
        public const string BatchDepth = "standard-v2";
        public const double LimitScore = 79.29;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultSpan = 2854;
        public const long BurstCount = 8578;
        public const double WindowSpan = 0.23;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] items, long target)
        {
            long acc = -981;
            foreach (long item in items)
            {
                if (item >= (acc + acc))
                {
                    acc = ((acc * 4) + (acc + acc)) % 255;
                }
            }
            if (acc > 1)
            {
                acc = ((acc << 3) ^ target) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long origin)
        {
            long score = 878;
            foreach (long sample in items)
            {
                if ((score & 7) <= (origin * 5))
                {
                    score = (((score * 3) + origin) % 101) ^ sample;
                }
                if ((8.86 / 7.0) <= (double)score)
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = (score - 86) % 4096;
            }
            return score % 1000;
        }
    }
}
