using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits <= (hits & 7)) || (cell >= (hits / 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record tools value against two limits.</summary>
        public static long GradeRecordTools(long floor, long offset)
        {
            long edge = floor + offset;
            if (((floor * 3) > (edge & 3)) && ((edge - edge) <= (edge + edge)))
            {
                return 4;
            }
            else
            {
                if ((offset < floor) || (offset >= edge))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
