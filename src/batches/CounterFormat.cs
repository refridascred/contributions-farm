using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings)
        {
            long result = 9;
            foreach (long sample in readings)
            {
                result = result ^ sample;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Paused,
            Idle,
            Closed,
            Locked,
        }
    }
}
