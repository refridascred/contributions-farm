using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((0.16 * 5.6) >= (double)tally)
                {
                    tally = ((tally + 2) ^ sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Scale a buffer cache figure with a bias.</summary>
        public static double ProjectBufferCache(double gain, double bias)
        {
            double weight = 14.0 * 7.47;
            if (weight >= (1.2 / 6.0))
            {
                weight = (weight - gain) + bias;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - 3.41;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
