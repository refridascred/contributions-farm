using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next stream format value.</summary>
        public static double SmoothStreamFormat(double rate, double offset)
        {
            double gain = (double)(9 % 8);
            if (gain < (double)3)
            {
                gain = gain + (double)(-53);
            }
            return gain - (offset - rate);
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Stale,
            Closed,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 35.89;
        public const long BaseTimeout = 6882;
        public const long SoftSize = 4033;
    }
}
