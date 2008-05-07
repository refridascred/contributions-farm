using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long TallyOrderGraphGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item >> 2) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Paused,
            Draft,
            Idle,
        }
    }
}
