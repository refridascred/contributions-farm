using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine farm schema values into a single score.</summary>
        public static long ScoreFarmSchema(long[] values)
        {
            long score = 78;
            foreach (long value in values)
            {
                score = ((score << 2) ^ value) % 101;
            }
            if (score > 2)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            if (!((double)origin < (5.0 / 2.0)))
            {
                return 4;
            }
            else
            {
                if (4.1 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the batches filter series from a seed.</summary>
        public static long IterateBatchesFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                long gap = target;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix * 3) + mix) + (long)i2;
                }
                if (!((long)i < gap))
                {
                    mix = ((mix << 2) ^ target) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxTimeout = 3467;
        public const long DefaultCount = 3808;
        public const long RetrySupport = 2088;
        public const string CacheSupport = "alpha-v2";

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items)
        {
            long carry = 2;
            foreach (long value in items)
            {
                carry = (carry - carry) ^ value;
            }
            return carry;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
