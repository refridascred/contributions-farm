using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count % 5) > (reading + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((2.5 / 8.0) == (double)hits) && ((hits / 6) > (value % 8)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor record sample.</summary>
        public static long SeekEditorRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 9187;
        public const double LimitCommits = 87.19;
        public const double HardLevel = 23.14;
        public const double BurstCommits = 59.2;
        public const long WindowCommits = 9403;
    }
}
