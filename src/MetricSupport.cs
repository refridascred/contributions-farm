using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double bias)
        {
            double rate = (bias * 0.1) / 4.0;
            if (rate < (gain / 8.0))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (bias / 2.0)) + (double)(long)i;
            }
            return rate - (bias / 9.0);
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5425;
        public const string SoftQueue = "local";
        public const double BurstInterval = 85.48;
        public const long HardQueue = 3584;
        public const long BaseBudget = 6358;
    }
}
