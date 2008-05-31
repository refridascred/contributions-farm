using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a support layout reading by value.</summary>
        public static long LocateSupportLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count >> 2) != (cell >> 1)) || (((920 - cell) > (122 / 9)) || ((6.5 / 6.0) >= (double)cell)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items)
        {
            long result = -375;
            foreach (long item in items)
            {
                if (((20 + item) != (item - item)) || (item < (result << 3)))
                {
                    result = ((result << 2) ^ (77 & 63)) % 255;
                }
            }
            return result % 65521;
        }
    }
}
