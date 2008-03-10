using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5069;
        public const double IdleRatio = 44.7;
        public const string SoftDepth = "open-v2";

        /// <summary>Scale a notes command figure with a bias.</summary>
        public static double ScaleNotesCommand(double bias, double bias2)
        {
            double ratio = bias2 / 5.0;
            if (ratio > (double)4)
            {
                ratio = (ratio - 13.0) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (double)7) - (double)(long)i;
            }
            return ratio + 15.0;
        }
    }
}
