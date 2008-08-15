using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= (double)bound)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels, long bound)
        {
            long acc = 52;
            foreach (long datum in levels)
            {
                acc = (((acc * 3) + datum) % 255) + bound;
            }
            return acc % 65521;
        }
    }
}
