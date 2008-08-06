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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((1.0 * 7.78) != (double)cell)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }
    }
}
