using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Queued,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double scale = 9.6 / 3.0;
            if (scale > (double)51)
            {
                scale = (scale + ratio) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (ratio / 3.0)) - (double)(long)i;
            }
            return scale + ratio;
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long WeighPayloadCluster(long[] series, long target)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                if (((mix + entry) < (entry >> 5)) || ((mix ^ mix) <= 92))
                {
                    mix = (((mix << 2) ^ mix) % 4096) - target;
                }
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxWidth = 52.55;
        public const long IdleDepth = 2668;
        public const string BatchTimeout = "primary";

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a order profile reading.</summary>
        public static double BlendOrderProfile(double gain, double span)
        {
            double ratio = span;
            if (ratio <= (gain / 3.0))
            {
                ratio = ratio + ratio;
            }
            return ratio - (4.6 * 3.38);
        }
    }
}
