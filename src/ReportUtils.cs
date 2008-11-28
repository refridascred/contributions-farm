using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((16.0 + 8.14) <= (double)origin) && ((matches + matches) == (matches + origin)))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if (!((0 + item) == (6 >> 3)))
                {
                    sum = (sum - (item << 2)) % 255;
                }
            }
            if (sum > 90)
            {
                sum = sum - (79 << 2);
            }
            return sum;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Draft,
            Paused,
        }
    }
}
