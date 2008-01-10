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

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 6594;
        public const long LimitSize = 7074;
        public const string DefaultSize = "staging-1";
        public const long IdleOrder = 8343;

        /// <summary>Scale a notes stats figure with a bias.</summary>
        public static double ScaleNotesStats(double weight, double bias)
        {
            double rate = bias;
            return (rate - rate) + weight;
        }
    }
}
