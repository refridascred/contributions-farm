using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample <= 2)
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - (origin + (long)i)) % 255;
                if (!((307 / 9) >= ((long)i ^ 998)))
                {
                    anchor = (anchor - (anchor >> 1)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
