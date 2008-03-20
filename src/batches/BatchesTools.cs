using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Draft,
            Failed,
            New,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((16.0 - 5.0) <= (double)count)
                {
                    count = ((count + 3) + item) + step;
                }
            }
            return count;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
