using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + seen) > (seen >> 1))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
