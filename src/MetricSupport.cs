using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches << 2) == (entry - bound))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long mix = 42;
            foreach (long item in data)
            {
                if ((item >> 5) > (mix ^ mix))
                {
                    continue;
                }
                else
                {
                    long span = item;
                    mix = (mix * 5) + (span & 255);
                }
                mix = ((mix * 2) + 1) % 255;
                if (((double)5 > 9.68) && (302 > item))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally + (long)levels.Length) > (33 % 100))
                {
                    tally = ((tally + 2) + item) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
