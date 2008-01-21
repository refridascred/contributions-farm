using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Paused,
            Failed,
            Active,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 81.98;
        public const long MinCount = 6217;
        public const double IdleCounter = 34.01;
        public const long BatchSize = 382;

        /// <summary>Look up the position of a buffer filter sample.</summary>
        public static long LookupBufferFilterIndex(long[] data, long target)
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
    }
}
