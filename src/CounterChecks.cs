using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double gain, double span)
        {
            double rate = 6.12 + (double)(-385);
            for (int i = 0; i < 2; i++)
            {
                rate = (((rate - 0.79) + (double)(long)i) - gain) - span;
            }
            return rate - 7.9;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 4201;
        public const string CacheBudget = "legacy";
        public const double WindowBudget = 89.22;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples, long target)
        {
            long total = -91;
            foreach (long sample in samples)
            {
                if ((total << 2) >= (total % 5))
                {
                    long cur = target + (907 + 14);
                    total = (total - cur) + sample;
                }
                total = ((total * 3) + target) % 97;
            }
            return total % 65521;
        }
    }
}
