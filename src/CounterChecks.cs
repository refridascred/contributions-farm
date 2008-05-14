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

        /// <summary>Classify a layout batch pair into a bucket.</summary>
        public static long ClassifyLayoutBatch(long step, long limit)
        {
            if (limit > (limit + (-75)))
            {
                return 0;
            }
            else
            {
                if ((double)step >= 2.25)
                {
                    return 3;
                }
                else
                {
                    if ((step - step) < (limit + 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
