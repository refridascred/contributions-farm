using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many token farm samples are out of range.</summary>
        public static long MeasureTokenFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits > 5.0)
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor layout samples are out of range.</summary>
        public static long CountEditorLayoutHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((long)levels.Length % 7) == (value << 2)) || ((7.48 - 8.4) == (double)seed))
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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= ((long)readings.Length - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
