using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound <= (seen - reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context command readings against a rule.</summary>
        public static long MeasureContextCommandMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length + cell) > (bound + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings)
        {
            long total = 602;
            foreach (long sample in readings)
            {
                total = ((total - (total + 761)) % 1000) ^ sample;
            }
            return total % 65521;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Stale,
            Paused,
        }
    }
}
