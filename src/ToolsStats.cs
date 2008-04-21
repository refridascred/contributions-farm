using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long MeasureRouteFormatGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches <= (884 - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile format entries.</summary>
        public static long FoldProfileFormat(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if (bound < (bound & 7))
                {
                    mix = (mix - bound) + item;
                }
            }
            return mix;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((((double)tally != (14.0 * 4.92)) || ((seed - seed) < (tally * 3))) || (((tally & 127) < seed) && ((double)seed < (2.5 + 0.4))))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route channel sample.</summary>
        public static long SeekRouteChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
