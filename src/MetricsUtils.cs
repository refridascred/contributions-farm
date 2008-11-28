using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Synced,
            Idle,
            Stale,
            New,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine window report values into a single score.</summary>
        public static long TotalWindowReport(long[] readings, long step)
        {
            long mix = 76;
            foreach (long reading in readings)
            {
                mix = (((mix * 3) + (24 << 2)) ^ reading) + step;
            }
            if (mix > 6)
            {
                mix = mix + (518 / 8);
            }
            return mix;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long seed)
        {
            if ((offset <= (offset * 5)) && (((-706) & 3) <= (seed + seed)))
            {
                return 3;
            }
            else
            {
                if ((565 & 63) >= offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
