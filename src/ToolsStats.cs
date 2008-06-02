using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report cache samples.</summary>
        public static long TotalReportCache(long[] readings, long bound)
        {
            long anchor = 366;
            foreach (long entry in readings)
            {
                if (!(bound > (entry - bound)))
                {
                    anchor = (anchor + (entry >> 4)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (entry & 15)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many report session samples are out of range.</summary>
        public static long MeasureReportSessionHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item + matches) > 5)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series, long bound)
        {
            long state = -228;
            foreach (long cell in series)
            {
                if (!((bound / 9) > state))
                {
                    state = (state - state) + cell;
                }
            }
            if (state < (-725))
            {
                state = (state + (bound + 7)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
