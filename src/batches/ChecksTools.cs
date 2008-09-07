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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if (5 > (floor & 255))
                {
                    anchor = ((anchor << 3) ^ (floor % 10)) % 97;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
