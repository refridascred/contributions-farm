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

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double mean = (double)5 - (double)139;
            if (mean > 4.25)
            {
                mean = (mean - (gain * 17.0)) + floor;
            }
            return mean - (double)9;
        }
    }
}
