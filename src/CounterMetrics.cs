using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] items, long target)
        {
            long total = -40;
            foreach (long cell in items)
            {
                if (((double)target < (double)(-570)) && ((total & 7) >= (target >> 5)))
                {
                    total = (total - 793) ^ cell;
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long limit)
        {
            long acc = 54;
            foreach (long item in readings)
            {
                acc = (((acc << 3) ^ acc) % 1000) + item;
                if ((limit ^ acc) >= (limit + acc))
                {
                    acc = (acc + (99 & 127)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 1735;
        public const string StepGithubfarm = "standard";
        public const string MaxSize = "standard-1";
        public const long BaseSpan = 1257;

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long target, long target2)
        {
            long offset = target + target2;
            if (5 < (target + target2))
            {
                return 6;
            }
            else
            {
                if (((double)target < 5.75) || (((-7) % 100) <= (offset * 4)))
                {
                    return 4;
                }
                else
                {
                    if (11.0 < (double)target2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
