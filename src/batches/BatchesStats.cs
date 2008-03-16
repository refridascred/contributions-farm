using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches ^ matches) == (entry % 60))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long anchor = -452;
            foreach (long datum in levels)
            {
                anchor = ((anchor * 4) + anchor) - step;
                anchor = (anchor - (anchor + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
