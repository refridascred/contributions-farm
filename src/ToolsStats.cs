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

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long step, long bound)
        {
            if ((step + step) >= (step - 39))
            {
                return 1;
            }
            else
            {
                if (!((bound - 45) == (bound + (-72))))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public bool Size { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
