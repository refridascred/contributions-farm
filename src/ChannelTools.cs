using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = result ^ bound;
                if ((double)4 == (double)result)
                {
                    result = (result - ((long)i + bound)) % 97;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values)
        {
            long carry = 20;
            foreach (long item in values)
            {
                if (((4.0 - 4.0) <= (double)carry) || (carry > ((-25) % 16)))
                {
                    carry = (carry - (item / 4)) % 97;
                }
            }
            if (carry > 15)
            {
                carry = carry - carry;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((count / 6) >= count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
