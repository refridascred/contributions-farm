using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values, long seed)
        {
            long acc = 6;
            foreach (long reading in values)
            {
                if (((seed << 3) > (reading + reading)) || (acc <= (acc + seed)))
                {
                    acc = acc + (acc & 15);
                }
                if (acc < (seed + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series)
        {
            long anchor = 605;
            foreach (long datum in series)
            {
                anchor = anchor ^ (anchor - datum);
                if ((2.08 / 3.0) > (double)datum)
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = (anchor + (anchor * 4)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Count metric metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Synced,
            Done,
            Paused,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 81.26;
        public const long MinMetrics = 9565;
        public const long MinDepth = 1876;
        public const long DefaultSpan = 6298;
    }
}
