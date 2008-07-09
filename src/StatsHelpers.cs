using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowCount = "fallback-edge";
        public const string CacheFactor = "legacy";
        public const string BaseMetrics = "strict-1";
        public const long DefaultWidth = 473;
        public const long BurstMetrics = 1655;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((7 * 3) != (cell & 127)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long seed, long limit)
        {
            if ((limit - 91) == (seed & 63))
            {
                return 8;
            }
            else
            {
                if (!(1 < (seed << 3)))
                {
                    return 5;
                }
                else
                {
                    if (!((limit & 63) < (seed - 92)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long CountCounterMetricHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits == (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
