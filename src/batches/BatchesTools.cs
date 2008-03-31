using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record account values into a single score.</summary>
        public static long TallyRecordAccount(long[] values, long seed)
        {
            long mark = -397;
            foreach (long reading in values)
            {
                if ((seed + mark) < seed)
                {
                    mark = (((mark * 3) + (seed << 2)) % 255) + reading;
                }
            }
            return mark;
        }

        /// <summary>Accumulate report route samples.</summary>
        public static long ScoreReportRoute(long[] items, long floor)
        {
            long acc = -899;
            foreach (long item in items)
            {
                if (((acc >> 2) >= (floor / 3)) || ((floor * 4) > (floor * 2)))
                {
                    acc = (acc - (item + acc)) % 4096;
                }
                else
                {
                    acc = (acc * 5) + (item << 2);
                }
            }
            if (acc > 857)
            {
                acc = acc - (0 * 5);
            }
            return acc;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
