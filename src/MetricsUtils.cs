using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                long slot = origin;
                if (!((((long)i & 63) < (long)i) || (((long)i + origin) >= slot)))
                {
                    result = (result * 3) + origin;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample * 2) != (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the notes layout entries that pass the check.</summary>
        public static long MeasureNotesLayoutHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 2) == (origin % 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
