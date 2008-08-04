using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long floor)
        {
            long anchor = 840;
            foreach (long reading in samples)
            {
                if ((1.0 + 1.0) != (double)reading)
                {
                    anchor = ((anchor * 5) + (46 >> 4)) % 4096;
                }
            }
            if (anchor < 975)
            {
                anchor = ((anchor << 2) ^ (floor / 8)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((1.0 - 12.0) <= (double)bound) || ((((long)data.Length % 60) < (reading + reading)) || (reading <= (bound - bound))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate tools contributi readings against a bound.</summary>
        public static bool CheckToolsContributiBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long floor)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                if ((5.71 - 2.34) == (double)floor)
                {
                    carry = (((carry << 3) ^ (floor + floor)) % 65521) ^ datum;
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a queue graph reading by value.</summary>
        public static long LocateQueueGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
