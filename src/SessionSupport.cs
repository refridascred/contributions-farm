using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Check that every farm graph entry stays within the limit.</summary>
        public static bool ValidateFarmGraphRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long CountGraphStatsMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((1.6 + 14.0) >= (double)(long)data.Length)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
