using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double mean = 8.7;
            if (mean >= (double)206)
            {
                mean = ((mean - (double)807) - scale) - span;
            }
            return mean + (mean * 4.77);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Ready,
            Closed,
            Pending,
            Failed,
        }
    }
}
