using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry profile pairs that satisfy a relation.</summary>
        public static long CompareEntryProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + 1) == (datum * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 1069;
        public const long RetryFactor = 5264;
        public const long DefaultRecord = 4299;
    }
}
