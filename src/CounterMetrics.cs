using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next already filter value from a seed.</summary>
        public static long IterateAlreadyFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = mix ^ (mix >> 2);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total + (4 + (long)i);
                total = ((total * 4) + (origin / 4)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 392;
        public const long CacheRecord = 2478;
        public const long WindowLevel = 141;
        public const double LimitInterval = 97.1;
        public const double StepLevel = 37.75;
    }
}
