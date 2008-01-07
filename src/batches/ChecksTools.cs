using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((9.6 / 8.0) == (double)count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Done,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] items)
        {
            long mark = -427;
            foreach (long cell in items)
            {
                mark = (mark - (cell * 3)) % 97;
                if ((double)cell > (8.0 + 6.2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
