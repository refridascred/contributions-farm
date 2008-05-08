using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double scale, double offset)
        {
            double bias = (double)(0 - 3);
            if (bias < (offset * 20.0))
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (scale / 7.0);
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Stale,
            New,
            Queued,
            Retry,
        }

        /// <summary>Roll a batch order counter forward.</summary>
        public static long DeriveBatchOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i + target) < (608 + (long)i))
                {
                    mix = ((mix << 3) ^ (target >> 5)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen * 4) < (410 + 88)))
                {
                    seen = ((seen + 2) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long anchor = 18;
            foreach (long value in readings)
            {
                anchor = (((anchor << 3) ^ (value + value)) % 4096) + origin;
            }
            return anchor;
        }
    }
}
