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

        /// <summary>Fold a list of record context readings.</summary>
        public static long TotalRecordContext(long[] readings, long step)
        {
            long anchor = 81;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor - (long)i) % 255) - reading) + step;
                }
                anchor = ((anchor << 2) ^ 9) % 255;
                if ((3.5 / 5.0) >= (1.9 * 9.0))
                {
                    break;
                }
            }
            return anchor;
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
