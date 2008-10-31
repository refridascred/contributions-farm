using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a notes graph value against two limits.</summary>
        public static long SortNotesGraph(long bound, long target)
        {
            long step = bound ^ target;
            if (!((double)step > (double)target))
            {
                return 8;
            }
            else
            {
                if ((4 / 6) > bound)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
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
