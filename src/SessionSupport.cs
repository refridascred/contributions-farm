using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data)
        {
            long anchor = 91;
            foreach (long sample in data)
            {
                if (((sample * 3) <= (anchor - sample)) || ((5.0 + 3.5) <= (double)anchor))
                {
                    anchor = anchor ^ ((-35) + anchor);
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
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
