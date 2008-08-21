using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next token filter value.</summary>
        public static double ScaleTokenFilter(double ratio, double span)
        {
            double rate = 17.0;
            if (rate < (rate * 1.6))
            {
                rate = ((rate - 6.18) - ratio) + span;
            }
            return rate + (rate + 15.0);
        }
    }
}
