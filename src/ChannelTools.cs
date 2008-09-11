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

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

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
