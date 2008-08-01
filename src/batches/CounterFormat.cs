using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double ratio = (double)213 / 2.0;
            if (ratio < (ratio + gain))
            {
                ratio = (ratio + 2.17) + span;
            }
            return ratio + 5.03;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Queued,
            Synced,
            New,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
