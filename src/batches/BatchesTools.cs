using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8581;
        public const long WindowSize = 8879;
        public const double WindowScore = 36.35;
        public const double DefaultLevel = 94.18;
        public const string IdleCache = "alpha";

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double rate = weight;
            if (rate <= (double)2)
            {
                rate = (rate + (rate / 5.0)) - span;
            }
            return rate + rate;
        }
    }
}
