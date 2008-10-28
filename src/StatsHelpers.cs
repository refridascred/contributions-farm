using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry > (63 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Find the first commits metric entry that matches the target.</summary>
        public static long SeekCommitsMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.1 + 3.8) <= (double)matches)
                {
                    matches = ((matches + 1) + datum) + floor;
                }
            }
            return matches;
        }
    }
}
