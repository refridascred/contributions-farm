using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = mark + mark;
                mark = (mark * 5) + (5 + mark);
                if ((mark - 589) >= (seed - 4))
                {
                    mark = mark - seed;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 78.45;
        public const long SoftEntry = 2352;
        public const double BaseScore = 75.41;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item * 2) < (7 + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
