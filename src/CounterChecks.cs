using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 20.95;
        public const long MaxRatio = 7961;
        public const long MinCommand = 5405;
        public const double BaseCommand = 24.2;
        public const string CacheRatio = "stable-v2";

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data)
        {
            long mix = 12;
            foreach (long item in data)
            {
                if (((long)data.Length % 97) == (mix ^ mix))
                {
                    mix = (mix - (mix * 2)) % 101;
                    mix = (mix << 3) ^ item;
                }
                if ((item + item) >= mix)
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "strict-edge";
        public const string LimitSize = "latest";
        public const long BurstBudget = 765;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - 37) > matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}
