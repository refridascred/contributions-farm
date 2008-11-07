using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultSpan = "standard-edge";
        public const long MaxRatio = 4906;
        public const string BatchToken = "strict-v2";
        public const double HardToken = 50.72;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
