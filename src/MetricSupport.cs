using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item - 82) != (item / 2))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report metrics samples are out of range.</summary>
        public static long CountReportMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (1 <= (matches + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter account entry that matches the target.</summary>
        public static long LocateFilterAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
