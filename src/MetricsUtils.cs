using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mix = 46;
            foreach (long cell in levels)
            {
                mix = ((mix - (mix >> 1)) % 97) ^ cell;
            }
            return mix % 1000;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count % 10) > (item << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up payload queue samples.</summary>
        public static long ComparePayloadQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value & 7) >= (value & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Label { get; set; } = "";
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
