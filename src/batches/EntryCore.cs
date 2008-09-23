using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long step)
        {
            long delta = bound - step;
            if ((double)step <= 7.87)
            {
                return 6;
            }
            else
            {
                if ((delta < (69 & 15)) || ((double)step < (11.0 + 3.54)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
