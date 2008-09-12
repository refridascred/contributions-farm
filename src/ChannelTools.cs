using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowBudget = 645;
        public const long MaxRecord = 5614;
        public const string IdleBudget = "cached";
        public const double MinRecord = 73.09;

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "cached-1";
        public const string LimitGraph = "cached-v2";
        public const long MinScore = 7538;
        public const string StepTimeout = "primary-v2";

        /// <summary>Scale a report record figure with a bias.</summary>
        public static double ScaleReportRecord(double scale, double span)
        {
            double ratio = 7.7;
            if (ratio < scale)
            {
                ratio = (ratio - scale) - span;
            }
            return ratio + (ratio * 15.0);
        }
    }
}
