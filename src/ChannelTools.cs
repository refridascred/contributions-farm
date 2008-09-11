using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double load = offset;
            if (load <= (2.0 * 17.0))
            {
                load = load + scale;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (load * 8.5);
        }

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
