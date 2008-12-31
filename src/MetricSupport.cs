using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long mix = 190;
            foreach (long value in data)
            {
                mix = ((mix + (mix << 1)) % 255) ^ value;
            }
            if (mix > 73)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Synced,
            Pending,
            Dropped,
            Queued,
        }
    }
}
