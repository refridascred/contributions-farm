using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Count the filter window entries that pass the check.</summary>
        public static long CountFilterWindowHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((11 >> 5) < (matches - matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((bound + 81) > bound) || (bound < (bound / 4)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
