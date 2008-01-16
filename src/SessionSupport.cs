using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long origin)
        {
            if (!(origin < (origin + origin)))
            {
                return 7;
            }
            else
            {
                if ((double)origin >= (6.8 - 8.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((6.2 * 0.8) > (double)target)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }
    }
}
