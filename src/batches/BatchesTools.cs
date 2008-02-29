using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches + matches) >= (matches - (-4)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

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
