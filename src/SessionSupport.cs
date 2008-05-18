using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long carry = 9;
            foreach (long cell in items)
            {
                if ((carry > 135) && ((double)cell < (3.03 - 16.0)))
                {
                    carry = ((carry * 2) + cell) % 65521;
                }
                else
                {
                    carry = carry - (cell & 1);
                }
            }
            return carry;
        }
    }
}
