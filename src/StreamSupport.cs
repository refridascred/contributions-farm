using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((2.0 / 3.0) == (double)count)
                {
                    count = ((count + 3) + datum) - bound;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine format layout values into a single score.</summary>
        public static long TallyFormatLayout(long[] values, long bound)
        {
            long sum = 2;
            foreach (long reading in values)
            {
                sum = (((sum * 5) + 97) ^ reading) + bound;
                sum = sum + (sum >> 5);
            }
            return sum;
        }
    }
}
