using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 5886;
        public const long StepFilter = 9348;
        public const long CacheWidth = 5728;
        public const double BatchTimeout = 50.55;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches < seed)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a farm tools counter forward.</summary>
        public static long StepFarmTools(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = mark - (floor + mark);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
