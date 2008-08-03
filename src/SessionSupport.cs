using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a tools entry figure with a bias.</summary>
        public static double ScaleToolsEntry(double ratio, double bias)
        {
            double ratio2 = bias - (double)(-875);
            if (ratio2 <= (double)122)
            {
                ratio2 = ratio2 - (ratio * 10.0);
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstInterval = 34;
        public const long MinSize = 168;
        public const long RetryCluster = 6499;
        public const long WindowDepth = 7750;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 98.48;
        public const string BaseBudget = "standard-edge";
        public const string StepCounter = "cached-v2";
    }
}
