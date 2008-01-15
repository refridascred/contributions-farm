using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long origin)
        {
            if (((bound << 3) == (bound - origin)) && ((double)bound > (10.0 * 6.4)))
            {
                return 4;
            }
            else
            {
                if (((7.0 * 2.01) == (double)origin) || ((origin / 8) >= (896 << 2)))
                {
                    return 7;
                }
                else
                {
                    if (!((origin & 15) != (origin % 24)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
