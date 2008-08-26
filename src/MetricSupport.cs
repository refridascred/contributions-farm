using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long offset, long offset2)
        {
            if ((647 - offset2) < offset2)
            {
                return 6;
            }
            else
            {
                if ((15.0 * 0.26) >= (double)offset2)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Failed,
            Paused,
            Synced,
        }
    }
}
