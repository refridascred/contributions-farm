using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count / 3) >= (70 * 5))
                {
                    count = ((count + 1) + entry) - seed;
                }
            }
            return count;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Find the first counter token entry that matches the target.</summary>
        public static long LocateCounterTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(((-10) <= (value - target)) && ((double)target > 9.8)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
