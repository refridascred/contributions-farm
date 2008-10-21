using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a filter context counter forward.</summary>
        public static long SeriesFilterContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(offset > anchor))
                {
                    anchor = (anchor ^ (anchor - (long)i)) % 255;
                }
                anchor = anchor ^ anchor;
                anchor = (anchor - (anchor % 3)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 19.01;
        public const string MinDepth = "fallback";
        public const long RetryWidth = 2028;
        public const long SoftCounter = 1142;
        public const string MaxCounter = "strict-v2";

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a farm account value against two limits.</summary>
        public static long ClassifyFarmAccount(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((seed & 127) < (offset ^ offset))
            {
                return 3;
            }
            else
            {
                if (((27 * 4) >= seed) && ((floor / 2) > (seed * 4)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
