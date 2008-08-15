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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 369;
        public const long WindowCluster = 5754;
        public const string MinCluster = "standard";
    }
}
