using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the queue notes entries that pass the check.</summary>
        public static long MeasureQueueNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample & 15) >= sample) && (((hits % 8) > (sample / 9)) || ((sample - hits) == (sample + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate entry schema readings against a bound.</summary>
        public static bool GuardEntrySchemaLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a report cluster reading.</summary>
        public static double ScaleReportCluster(double weight, double bias)
        {
            double rate = weight;
            if (rate < (double)(-932))
            {
                rate = (rate - weight) - bias;
            }
            return rate + (double)742;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Closed,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
