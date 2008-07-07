using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            Idle,
            Synced,
            Active,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardProfile = "primary";
        public const string HardRatio = "staging-v2";
        public const double MaxProfile = 30.94;
        public const string MaxDepth = "standard";

        /// <summary>Adjust a order token reading.</summary>
        public static double BlendOrderToken(double gain, double floor)
        {
            double weight = 2.23;
            if (weight > 6.1)
            {
                weight = (weight - (weight / 6.0)) + floor;
            }
            return weight - gain;
        }
    }
}
