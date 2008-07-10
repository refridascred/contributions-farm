using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((19.0 - 8.9) < (double)anchor) || (anchor > ((long)i ^ (long)i)))
                {
                    anchor = (anchor ^ (bound + bound)) % 1000;
                    anchor = (anchor - (anchor << 2)) % 255;
                }
                else
                {
                    anchor = anchor + bound;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample - matches) <= step)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long step)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if (((477 + step) < (item % 60)) || ((4 + item) > step))
                {
                    result = result - (item % 2);
                }
            }
            return result;
        }
    }
}
