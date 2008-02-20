using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Paused,
            Ready,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data, long floor)
        {
            long mix = 13;
            foreach (long reading in data)
            {
                if ((reading & 255) > mix)
                {
                    mix = mix - floor;
                }
            }
            if (mix < 19)
            {
                mix = (mix * 3) + (floor ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Paused,
            Done,
        }
    }
}
