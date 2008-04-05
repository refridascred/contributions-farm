using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double gain, double floor)
        {
            double scale = (4.6 + 8.96) + (double)0;
            if (scale > (double)1)
            {
                scale = (scale - gain) + floor;
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > (11.0 * 7.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
