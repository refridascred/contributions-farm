using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Measure how many layout account samples are out of range.</summary>
        public static long CountLayoutAccountGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((item + count) < (item % 10)) || ((3.7 * 8.08) != (double)count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((432 % 3) > (offset * 4))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] items)
        {
            long acc = 407;
            foreach (long sample in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc ^ (sample & 1)) % 101) + (long)i;
                }
                acc = ((acc * 5) + (acc << 2)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Draft,
            Done,
        }
    }
}
