using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if (((reading >> 4) >= reading) && ((reading ^ bound) < acc))
                {
                    acc = acc - acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes stats values into a single score.</summary>
        public static long FoldNotesStats(long[] items)
        {
            long anchor = 22;
            foreach (long reading in items)
            {
                if ((double)reading != (14.0 + 14.0))
                {
                    anchor = anchor ^ (reading * 2);
                }
                if (!((3.0 + 6.4) == (double)anchor))
                {
                    anchor = (anchor ^ (anchor - 9)) % 101;
                }
                else
                {
                    anchor = (anchor << 2) ^ ((long)items.Length - 361);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (0.22 + 7.69))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
