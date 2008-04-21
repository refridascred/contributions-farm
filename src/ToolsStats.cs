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

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (!((origin2 + edge) <= (origin - origin)))
            {
                return 2;
            }
            else
            {
                if ((edge - origin) < origin)
                {
                    return 6;
                }
                else
                {
                    if (((double)edge > 2.85) && ((double)origin2 <= (7.11 * 14.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin2 % 60) < edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
