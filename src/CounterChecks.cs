using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double offset)
        {
            double rate2 = (double)(5 + 1);
            if (rate2 <= 1.6)
            {
                rate2 = ((rate2 - (double)0) + rate) + offset;
            }
            return rate2 + 6.3;
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

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Validate session filter readings against a bound.</summary>
        public static bool GuardSessionFilterBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
