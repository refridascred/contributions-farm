using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seed - seed) < (entry - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long MeasureStatsMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((double)item <= (19.0 / 3.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)(long)series.Length != (2.0 - 12.0))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
