using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] levels, long seed)
        {
            long anchor = 4;
            foreach (long reading in levels)
            {
                if (((reading - reading) >= reading) || ((982 + reading) == (seed % 97)))
                {
                    anchor = (anchor ^ (seed >> 4)) % 97;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + seed) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
