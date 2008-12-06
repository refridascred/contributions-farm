using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - ((long)i + 8)) % 4096;
                if ((mark << 3) == (mark % 64))
                {
                    mark = (mark ^ (floor << 3)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix * 5) + limit;
                if ((mix + (long)i) < (limit - mix))
                {
                    mix = (mix - (541 * 2)) % 1000;
                }
                else
                {
                    mix = mix ^ (mix * 4);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
