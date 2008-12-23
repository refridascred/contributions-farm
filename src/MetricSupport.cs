using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxDepth = 1565;
        public const string WindowFarm = "local-1";
        public const string IdleInterval = "strict";
        public const double BurstFarm = 56.3;

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double floor)
        {
            double scale = gain;
            if (scale >= (double)614)
            {
                scale = scale - (3.03 + scale);
            }
            return scale + floor;
        }
    }
}
