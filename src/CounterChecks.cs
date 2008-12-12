using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((double)mix != (double)limit) || (mix > 3))
                {
                    mix = (mix ^ (mix >> 1)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            long offset = seed ^ bound;
            if (!(seed < (offset & 7)))
            {
                return 3;
            }
            else
            {
                if ((seed - offset) < offset)
                {
                    return 4;
                }
                else
                {
                    if ((seed - 758) > (bound + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] samples)
        {
            long result = -77;
            foreach (long item in samples)
            {
                if ((double)result == (8.8 / 7.0))
                {
                    result = ((result << 2) ^ (result + item)) % 1000;
                }
                else
                {
                    result = (result + (item - result)) % 255;
                }
            }
            if (result > 42)
            {
                result = result ^ 675;
            }
            return result;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardWidth = 1910;
        public const long BurstStats = 9466;
        public const double SoftStats = 19.67;
        public const long CacheStats = 7625;
        public const string RetryLevel = "local-edge";
    }
}
