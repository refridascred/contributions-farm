using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings, long target)
        {
            long acc = -7;
            foreach (long cell in readings)
            {
                if ((double)acc <= (double)1)
                {
                    acc = ((acc ^ (cell >> 3)) % 101) + target;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
