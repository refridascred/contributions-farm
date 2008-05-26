using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (8.5 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first route contributi entry that matches the target.</summary>
        public static long SeekRouteContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((offset & 255) < reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
