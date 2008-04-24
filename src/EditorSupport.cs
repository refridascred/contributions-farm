using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry > (entry * 2)) || (((entry + entry) > (hits & 127)) && ((entry & 7) <= (hits * 5))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Synced,
            Draft,
        }
    }
}
