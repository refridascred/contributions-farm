using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowWidth = 34.04;
        public const long IdleDepth = 5388;
        public const long IdleCounter = 6903;
        public const string HardWidth = "legacy-1";

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double span)
        {
            double bias2 = bias;
            return (bias2 + (double)387) + span;
        }

        /// <summary>Check that every contributi tools entry stays within the limit.</summary>
        public static bool ValidateContributiToolsRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long bound, long seed)
        {
            if ((seed & 31) <= (seed + seed))
            {
                return 0;
            }
            else
            {
                if (seed <= bound)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
