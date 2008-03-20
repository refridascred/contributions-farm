using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 6322;
        public const long LimitInterval = 3390;
        public const long IdleContext = 2113;
        public const long MaxContext = 7776;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score ^ ((long)i & 127)) ^ (long)i2;
                }
                if ((7.9 / 2.0) >= (double)seed)
                {
                    score = score - (score ^ seed);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
