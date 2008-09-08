using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a tools graph reading by value.</summary>
        public static long LookupToolsGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream record readings against a rule.</summary>
        public static long AuditStreamRecordOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches & 15) >= sample)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics layout entries that pass the check.</summary>
        public static long MeasureMetricsLayoutMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((9.07 / 8.0) >= (0.06 + 7.7)))
                {
                    tally = ((tally + 2) - sample) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Dropped,
            Stale,
        }
    }
}
