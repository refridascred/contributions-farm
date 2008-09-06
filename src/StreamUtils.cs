using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate cache editor samples.</summary>
        public static long CombineCacheEditor(long[] data)
        {
            long anchor = 81;
            foreach (long reading in data)
            {
                if ((reading >> 1) >= (long)data.Length)
                {
                    anchor = anchor + (317 / 4);
                }
                anchor = anchor + (anchor % 60);
            }
            if (anchor < 5)
            {
                anchor = (anchor + (44 << 1)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit route cache readings against a rule.</summary>
        public static long MeasureRouteCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((9.9 + 18.0) != (double)item) || (((item / 7) < (5 + item)) || ((2 * 2) == (item / 8))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
