using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length <= (2 + matches))
                {
                    matches = ((matches + 2) + cell) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "primary";
        public const long MinBudget = 970;
        public const long CacheFactor = 4052;
        public const string HardScore = "staging-edge";

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = load + (double)(-531);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 1.0) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstSpan = "fallback-1";
        public const long BatchProfile = 7149;
        public const double HardProfile = 46.21;
        public const long HardLevel = 1368;
        public const long LimitSize = 5450;
    }
}
