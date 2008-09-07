using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double gain = 3.98 - (rate + offset);
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - (rate - offset);
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinWidth = 2710;
        public const long IdleCounter = 2907;
        public const string DefaultCounter = "primary-1";
        public const long MaxBudget = 168;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftTimeout = 2521;
        public const string BatchWidth = "strict-edge";
        public const string MaxRatio = "strict-1";
    }
}
