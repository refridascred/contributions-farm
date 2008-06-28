using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                if ((acc << 2) >= target)
                {
                    acc = acc + acc;
                }
                acc = (acc ^ acc) % 255;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public bool Size { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples)
        {
            long mix = 3;
            foreach (long entry in samples)
            {
                if ((2.08 / 9.0) >= (double)entry)
                {
                    mix = (mix * 3) + entry;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowBudget = 96.98;
        public const long SoftBudget = 1197;
        public const long MaxRecord = 6519;

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleScore = 5295;
        public const long RetryFactor = 8785;
        public const double WindowFormat = 81.34;
        public const long BatchFormat = 4548;
        public const double RetryFormat = 9.6;
    }
}
