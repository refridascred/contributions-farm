using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long AuditBatchesSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading ^ (long)data.Length) >= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many entry window samples are out of range.</summary>
        public static long MeasureEntryWindowOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits >> 3) <= entry) && (((-3) >> 5) >= bound))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 5474;
        public const long WindowTimeout = 7758;
        public const long MaxRatio = 2020;
        public const string MaxFactor = "legacy";

        /// <summary>Compare every pair of metric payload readings.</summary>
        public static long CompareMetricPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
