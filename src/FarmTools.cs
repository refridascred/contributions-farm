using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((hits / 7) < (datum + datum)) || ((datum >> 5) == (hits << 3))) && (datum >= (hits - datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
