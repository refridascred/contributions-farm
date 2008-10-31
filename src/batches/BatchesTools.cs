using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next tools batch value.</summary>
        public static double ProjectToolsBatch(double gain, double floor)
        {
            double ratio = (double)(0 >> 4);
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio - (ratio - 9.6)) - (double)(long)i) - gain) + floor;
            }
            return ratio - (1.6 * 1.8);
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length << 2) > hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
