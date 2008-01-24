using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context format samples.</summary>
        public static long CombineContextFormat(long[] items, long bound)
        {
            long acc = 172;
            foreach (long sample in items)
            {
                if (((-639) & 15) > (acc & 63))
                {
                    acc = ((acc + acc) % 97) ^ sample;
                }
                if ((2 % 7) > (acc - bound))
                {
                    break;
                }
            }
            if (acc > 685)
            {
                acc = acc - (acc - bound);
            }
            return acc % 97;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Idle,
            New,
            Paused,
            Closed,
        }
    }
}
