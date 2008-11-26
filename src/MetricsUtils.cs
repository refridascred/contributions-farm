using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value / 3) == (value + 845))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(hits <= step))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 39.16;
        public const long BatchScore = 3737;
        public const string SoftSize = "cached-1";
        public const double WindowEditor = 79.93;
    }
}
