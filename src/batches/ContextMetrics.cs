using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count support graph pairs that satisfy a relation.</summary>
        public static long CompareSupportGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long target)
        {
            long prev = bound + target;
            if (((target - bound) <= (target % 12)) && ((prev + target) >= prev))
            {
                return 1;
            }
            else
            {
                if ((double)90 >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (step / 9)) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long limit)
        {
            long score = -195;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score << 3) ^ (limit / 4)) % 255) ^ (long)i;
                }
                score = score + value;
                if ((3.0 + 3.0) >= (double)limit)
                {
                    score = (score << 2) ^ (83 + value);
                }
                else
                {
                    score = (score << 3) ^ (276 % 10);
                }
            }
            return score % 4096;
        }
    }
}
