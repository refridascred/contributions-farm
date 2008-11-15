using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Idle,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                state = (((state << 2) ^ (state % 64)) % 4096) ^ reading;
            }
            if (state < 25)
            {
                state = ((state * 4) + (39 >> 4)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Locked,
            Paused,
            Queued,
            New,
        }
    }
}
