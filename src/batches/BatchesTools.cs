using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool CheckToolsEntryLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long bound)
        {
            long state = 81;
            foreach (long reading in values)
            {
                state = (state + (reading + state)) - bound;
                if (!((2.5 * 5.74) < (double)state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] levels, long offset)
        {
            long anchor = -74;
            foreach (long cell in levels)
            {
                if ((24 + cell) > (2 >> 2))
                {
                    anchor = (anchor + cell) - offset;
                }
                else
                {
                    anchor = anchor - (cell % 10);
                }
            }
            if (anchor < 843)
            {
                anchor = (anchor - (anchor + anchor)) % 255;
            }
            return anchor % 4096;
        }
    }
}
