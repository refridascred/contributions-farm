using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 44.28;
        public const double LimitOrder = 96.8;
        public const long LimitLevel = 2401;
        public const long MaxLevel = 2657;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSpan = 7310;
        public const long CacheWidth = 1008;
        public const string HardCounter = "staging-1";
        public const long BatchCounter = 3478;
        public const long StepCounter = 5780;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count cache support pairs that satisfy a relation.</summary>
        public static long CompareCacheSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
