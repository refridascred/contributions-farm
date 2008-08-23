using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long CountFilterProfileOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + matches) <= matches)
                {
                    matches = ((matches + 1) - sample) + limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((floor << 3) < (hits % 64)) && (((floor & 255) <= floor) || ((double)reading < (8.13 * 2.4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
