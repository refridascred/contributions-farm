using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Locked,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "staging-edge";
        public const string HardRatio = "open-v2";
        public const long BaseScore = 2452;
        public const long DefaultBatch = 1447;
        public const string LimitBudget = "primary-v2";

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double scale, double bias)
        {
            double load = scale - (double)1;
            if (load <= (load - scale))
            {
                load = (load + scale) + bias;
            }
            return load + load;
        }
    }
}
