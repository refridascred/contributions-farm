using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!!((reading + reading) >= reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings, long limit)
        {
            long anchor = 155;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor ^ limit) + (long)i;
                }
                if ((reading - 88) == (21 & 255))
                {
                    anchor = (anchor - (3 / 4)) % 4096;
                }
                else
                {
                    anchor = (anchor - (reading / 6)) % 101;
                }
                if ((1.6 * 5.02) <= (double)limit)
                {
                    break;
                }
            }
            if (anchor > 22)
            {
                anchor = ((anchor << 2) ^ ((long)readings.Length * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
