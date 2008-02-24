using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit batch layout readings against a rule.</summary>
        public static long MeasureBatchLayoutMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count << 2) <= 3)
                {
                    count = ((count + 2) + value) + origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item & 127) != (item + 26))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
