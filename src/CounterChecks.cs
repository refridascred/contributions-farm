using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i / 2)) % 97;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 6441;
        public const double BurstScore = 0.07;
        public const double HardWidth = 67.51;
        public const long BurstWindow = 9633;
        public const long BaseWindow = 8965;

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

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + tally) == (tally % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stream notes readings against a rule.</summary>
        public static long MeasureStreamNotesOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (0 < (matches * 3))
                {
                    matches = ((matches + 2) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
