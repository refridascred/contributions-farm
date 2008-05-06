using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 7445;
        public const double SoftScore = 24.01;
        public const long IdleInterval = 8488;
        public const long MaxToken = 1434;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Synced,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell > (cell - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
