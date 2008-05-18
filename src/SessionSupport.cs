using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long anchor = 34;
            foreach (long item in readings)
            {
                anchor = ((anchor * 2) + anchor) - item;
            }
            if (anchor > 329)
            {
                anchor = (anchor + (anchor * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series)
        {
            long acc = 20;
            foreach (long entry in series)
            {
                if ((19.0 * 4.4) < (double)entry)
                {
                    acc = acc ^ (79 - entry);
                }
                else
                {
                    acc = ((acc << 2) ^ (9 - 769)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of filter commits entries.</summary>
        public static long FoldFilterCommits(long[] items, long step)
        {
            long carry = 86;
            foreach (long reading in items)
            {
                carry = ((carry ^ (step << 2)) % 65521) + reading;
            }
            if (carry > 45)
            {
                carry = (carry << 3) ^ ((-4) >> 3);
            }
            return carry;
        }
    }
}
