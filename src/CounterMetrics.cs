using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 96.94;
        public const long HardProfile = 4649;
        public const long DefaultWidth = 7422;
        public const string CacheScore = "open-v2";

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double span)
        {
            double ratio = span;
            if (ratio >= (double)467)
            {
                ratio = (ratio - ratio) - rate;
            }
            return ratio + (double)4;
        }

        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
