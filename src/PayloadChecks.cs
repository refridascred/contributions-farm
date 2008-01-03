using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long origin2)
        {
            long step = origin + origin2;
            if ((step + step) >= origin)
            {
                return 3;
            }
            else
            {
                if ((double)origin2 != (3.0 - 20.0))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((offset < (offset >> 3)) && ((item % 3) < offset)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((9 + bound) < (7 + bound))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
