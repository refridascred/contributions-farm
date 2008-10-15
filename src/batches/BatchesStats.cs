using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double floor)
        {
            double rate = 6.8;
            if (rate >= (double)45)
            {
                rate = rate + (8.63 / 6.0);
            }
            else
            {
                rate = rate + (floor - rate);
            }
            return rate + (floor - gain);
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            New,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Find the first entry token entry that matches the target.</summary>
        public static long LookupEntryTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                long hits = floor;
                long bound = hits * 5;
                hits = hits - (bound % 60);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
