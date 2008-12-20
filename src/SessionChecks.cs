using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (3.0 > (double)seen)
                {
                    seen = ((seen + 3) ^ entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Count the command entry entries that pass the check.</summary>
        public static long CountCommandEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen + seen) >= sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((long)levels.Length <= (entry << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
