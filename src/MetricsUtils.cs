using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardWidth = 1792;
        public const long DefaultContributi = 1057;
        public const double MaxContributi = 88.68;

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

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 2039;
        public const long BatchCommits = 7771;
        public const long StepCommits = 6122;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 81.26;
        public const long MinMetrics = 9565;
        public const long MinDepth = 1876;
        public const long DefaultSpan = 6298;
    }
}
