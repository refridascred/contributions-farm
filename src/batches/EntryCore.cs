using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((floor << 3) >= (floor + floor)) || ((double)item != (3.0 - 9.02)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report window samples are out of range.</summary>
        public static long CountReportWindowHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (11 >= ((-366) + bound))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Derive the next editor farm value from a seed.</summary>
        public static long SeriesEditorFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + step) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
