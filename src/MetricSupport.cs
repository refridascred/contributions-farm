using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (double)268) + (double)(long)i) + rate;
            }
            return weight - (floor * 5.04);
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Done,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
