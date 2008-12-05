using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long offset)
        {
            long step = floor ^ offset;
            if (3.8 < (double)step)
            {
                return 4;
            }
            else
            {
                if ((20 ^ step) == (floor & 255))
                {
                    return 7;
                }
                else
                {
                    if ((step + floor) != (floor + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches >= (17.0 - 9.0))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a metrics profile reading by value.</summary>
        public static long LocateMetricsProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
