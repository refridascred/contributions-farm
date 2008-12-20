using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long mark = 78;
            foreach (long reading in samples)
            {
                if (mark < 9)
                {
                    mark = (((mark << 2) ^ (mark * 3)) % 97) ^ reading;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
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
