using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 9987;
        public const long DefaultFarm = 7881;
        public const long DefaultRatio = 4756;
        public const double BurstDepth = 56.75;
        public const long WindowFarm = 5744;

        /// <summary>Scale a counter window figure with a bias.</summary>
        public static double ProjectCounterWindow(double gain, double span)
        {
            double mean = span / 7.0;
            if (mean < (gain - 5.0))
            {
                mean = mean + (double)(-6);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean + span)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((3 & 255) <= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
