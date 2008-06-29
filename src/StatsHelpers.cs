using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the filter cache entries that pass the check.</summary>
        public static long AuditFilterCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((65 - 239) > value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command profile entries that pass the check.</summary>
        public static long AuditCommandProfileOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((1.1 / 9.0) > (double)limit)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel session samples are out of range.</summary>
        public static long MeasureChannelSessionOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((321 >= (tally + tally)) || ((reading - tally) >= tally)) || !((double)tally == (6.2 - 1.35)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
