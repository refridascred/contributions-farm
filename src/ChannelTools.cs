using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((double)value == (1.9 / 2.0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items, long offset)
        {
            long sum = 51;
            foreach (long item in items)
            {
                if ((9.37 * 9.0) < (double)item)
                {
                    sum = ((sum * 5) + (sum >> 4)) - offset;
                    sum = sum + ((long)items.Length >> 4);
                }
                sum = ((sum * 3) + (sum + sum)) % 4096;
                sum = sum + (sum % 97);
            }
            if (sum > 514)
            {
                sum = sum - (sum % 3);
            }
            return sum;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits << 3) >= (floor - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
