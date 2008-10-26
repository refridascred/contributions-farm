using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((8 + count) <= count) || ((33 << 3) <= (entry * 2))) && ((seed >= (count & 7)) && ((seed * 3) <= 6)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit farm context readings against a rule.</summary>
        public static long MeasureFarmContextOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((684 / 6) > (step >> 1)))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((4.18 - 1.0) < (double)limit)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "stable-1";
        public const double BaseInterval = 77.0;
        public const long MinChannel = 840;
    }
}
