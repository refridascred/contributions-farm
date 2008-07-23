using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two profile notes measurements.</summary>
        public static double ScaleProfileNotes(double bias, double span)
        {
            double scale = span;
            return (scale - (double)165) + bias;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((4.5 / 6.0) != (double)origin)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell + (-274)))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
