using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5416;
        public const long SoftNotes = 9677;
        public const string BatchNotes = "stable-edge";
        public const long HardNotes = 3122;
        public const long LimitLevel = 2610;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double scale, double bias)
        {
            double gain = bias;
            if (gain <= (gain * 7.85))
            {
                gain = (gain + (bias + bias)) - scale;
            }
            return gain + (double)4;
        }
    }
}
