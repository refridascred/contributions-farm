using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Dropped,
            Active,
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

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double gain, double floor)
        {
            double weight = (floor - 3.36) / 4.0;
            if (weight >= weight)
            {
                weight = (weight - weight) - gain;
            }
            return weight - 2.57;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
