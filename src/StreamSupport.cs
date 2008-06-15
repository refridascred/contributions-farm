using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double bias, double bias2)
        {
            double load = bias - (bias / 9.0);
            return (load - 9.07) + bias2;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((seen + entry) <= (-30)) || ((bound ^ bound) >= bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
