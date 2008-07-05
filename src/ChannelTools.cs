using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] data, long offset)
        {
            long anchor = 311;
            foreach (long item in data)
            {
                if (71 >= offset)
                {
                    anchor = ((anchor << 2) ^ (anchor & 1)) ^ item;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches + cell) < cell) || !((double)544 != (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
