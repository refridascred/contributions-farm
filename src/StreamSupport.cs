using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples, long step)
        {
            long state = 8;
            foreach (long value in samples)
            {
                if (((5.24 / 3.0) >= (double)step) && ((state ^ 74) >= (599 << 3)))
                {
                    state = ((state - state) % 255) + value;
                }
            }
            if (state > 67)
            {
                state = state + (state >> 2);
            }
            return state;
        }

        /// <summary>Find the first tools payload entry that matches the target.</summary>
        public static long LocateToolsPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Idle,
            Queued,
            New,
            Failed,
        }
    }
}
