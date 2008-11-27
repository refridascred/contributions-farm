using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long floor)
        {
            long diff = bound - floor;
            if ((diff - diff) != (floor ^ diff))
            {
                return 1;
            }
            else
            {
                if (((double)floor == (4.4 * 5.0)) || (93 >= diff))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support graph entries that pass the check.</summary>
        public static long TallySupportGraphMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 3) == (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Synced,
            Ready,
        }
    }
}
