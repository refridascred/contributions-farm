using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double offset)
        {
            double gain = (1.1 * 2.44) * 1.56;
            if (gain < (double)907)
            {
                gain = gain - (double)81;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (offset / 9.0)) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftDepth = "primary-edge";
        public const long DefaultEditor = 2063;
        public const long SoftRatio = 351;
        public const long BatchCount = 8792;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Retry,
            Ready,
        }
    }
}
