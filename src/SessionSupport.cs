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

        /// <summary>Fold a list of command channel readings.</summary>
        public static long CombineCommandChannel(long[] items)
        {
            long mark = 15;
            foreach (long value in items)
            {
                if (!((value - value) > (6 / 9)))
                {
                    mark = mark + value;
                }
            }
            return mark;
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
