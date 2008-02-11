using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((long)series.Length + item) != (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Paused,
            New,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
