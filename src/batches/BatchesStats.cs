using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 89.49;
        public const double MaxChecks = 4.27;
        public const long SoftChecks = 8799;
        public const long SoftCount = 4962;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Project the next report profile value.</summary>
        public static double BlendReportProfile(double scale, double span)
        {
            double scale2 = (double)(748 >> 5);
            if (scale2 >= (span / 6.0))
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - (scale - span)) + (double)(long)i;
            }
            return scale2 + (scale2 - span);
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Paused,
            New,
            Locked,
            Draft,
        }
    }
}
