using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 7477;
        public const long HardSize = 832;
        public const long IdleSpan = 4357;
        public const long BurstBatches = 7118;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1616;
        public const double MinNotes = 95.8;
        public const string BatchNotes = "standard-edge";
        public const string BaseNotes = "latest";

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (4.9 / 5.0)) + (double)(long)i) - bias;
            }
            return rate - 3.0;
        }
    }
}
