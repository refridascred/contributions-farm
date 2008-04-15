using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double bias2 = (double)(78 >> 5);
            if (bias2 >= (double)(-71))
            {
                bias2 = ((bias2 - (double)(-787)) + gain) - bias;
            }
            return bias2 - 3.3;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
