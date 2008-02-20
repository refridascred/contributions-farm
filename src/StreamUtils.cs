using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            New,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((count ^ 80) > (7 - 6)) || ((origin % 5) > (count * 4))) && (((origin & 3) >= (826 / 7)) || ((3.0 - 19.0) >= (double)count)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item > (item * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long seed)
        {
            long anchor = 641;
            foreach (long value in series)
            {
                if ((double)anchor < (double)seed)
                {
                    anchor = ((anchor - (3 + 621)) % 97) ^ value;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 4096;
        }
    }
}
