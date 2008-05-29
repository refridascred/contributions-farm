using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double floor)
        {
            double weight = floor + (1.58 + ratio);
            if (weight > (double)48)
            {
                weight = weight - 2.79;
            }
            else
            {
                weight = weight - (weight + weight);
            }
            return weight + (ratio * 9.01);
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Dropped,
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Queued,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double gain, double span)
        {
            double load = span;
            if (load > (gain / 6.0))
            {
                load = load + (load / 8.0);
            }
            return load + (double)0;
        }
    }
}
