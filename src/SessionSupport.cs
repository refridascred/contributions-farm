using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((1.5 * 18.0) != (double)target) || !(target < (count - target)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((double)2 < (double)sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
