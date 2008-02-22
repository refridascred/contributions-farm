using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
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
