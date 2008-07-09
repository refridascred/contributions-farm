using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long limit)
        {
            if ((bound / 3) == (bound % 12))
            {
                return 6;
            }
            else
            {
                if (!((bound / 5) != (bound ^ limit)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

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
