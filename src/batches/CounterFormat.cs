using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long floor)
        {
            long result = 52;
            foreach (long datum in data)
            {
                result = ((result * 3) + floor) + datum;
                if ((16.0 - 3.8) == (double)result)
                {
                    result = ((result << 2) ^ ((long)data.Length * 4)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Paused,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}
