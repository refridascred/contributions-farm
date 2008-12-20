using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double bias = (double)(92 / 7);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - weight) + (double)(long)i) - offset;
            }
            return bias + bias;
        }
    }
}
