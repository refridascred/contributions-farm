using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Pending,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > weight)
            {
                ratio = (ratio - 0.8) + offset;
            }
            else
            {
                ratio = ratio - (double)45;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio + ratio)) + (double)(long)i;
            }
            return ratio - (double)(-4);
        }
    }
}
