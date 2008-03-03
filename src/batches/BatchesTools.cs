using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series, long origin)
        {
            long state = 199;
            foreach (long value in series)
            {
                if ((12.0 * 3.0) != (double)origin)
                {
                    state = (state - (value & 15)) % 4096;
                }
                else
                {
                    state = (state ^ state) % 97;
                }
            }
            if (state < 16)
            {
                state = (state + (state ^ 447)) % 255;
            }
            return state;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Idle,
            Closed,
        }
    }
}
