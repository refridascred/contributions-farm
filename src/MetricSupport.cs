using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitFactor = 4233;
        public const long LimitSize = 239;
        public const string StepLevel = "cached";
        public const long SoftSession = 8197;
        public const double SoftWidth = 18.75;

        /// <summary>Blend two window report measurements.</summary>
        public static double ProjectWindowReport(double ratio, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 17.0) - (double)(long)i) - ratio;
            }
            return drift - 9.0;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
