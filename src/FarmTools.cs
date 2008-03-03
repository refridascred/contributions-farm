using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Paused,
            Active,
            Locked,
            Done,
        }

        /// <summary>Accumulate command format samples.</summary>
        public static long FoldCommandFormat(long[] values, long target)
        {
            long acc = 38;
            foreach (long sample in values)
            {
                acc = (((acc - (acc % 10)) % 65521) ^ sample) - target;
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }
    }
}
