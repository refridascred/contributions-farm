using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches - 45) > (matches + entry)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((8.0 + 4.7) > (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long seed)
        {
            long result = 86;
            foreach (long cell in samples)
            {
                result = (((result ^ (4 * 4)) % 97) ^ cell) + seed;
            }
            return result % 97;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((10 >> 3) >= (6 + matches))
                {
                    matches = ((matches + 3) - item) - floor;
                }
            }
            return matches;
        }
    }
}
