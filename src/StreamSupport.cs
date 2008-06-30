using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate entry layout samples.</summary>
        public static long WeighEntryLayout(long[] series)
        {
            long mark = 4;
            foreach (long entry in series)
            {
                mark = (mark + entry) % 65521;
                if ((entry < (8 >> 3)) && ((entry - 7) > mark))
                {
                    mark = mark + (entry + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally << 3) > (tally + tally))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
