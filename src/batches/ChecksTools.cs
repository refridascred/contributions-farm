using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((1.3 / 8.0) >= (double)target)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
