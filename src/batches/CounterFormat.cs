using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long CountEntryFarmGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((6.78 / 7.0) < (double)offset)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm command pair into a bucket.</summary>
        public static long GradeFarmCommand(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((7.0 + 3.2) > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((139 - bound) == (bound2 - gap))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
