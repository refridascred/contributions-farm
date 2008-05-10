using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long target)
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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = state - state;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (state - target)) % 101) ^ (long)i2;
                    state = (state - (state ^ state)) % 4096;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepSpan = 33.74;
        public const double HardSize = 41.76;
        public const long SoftInterval = 37;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Closed,
            New,
            Ready,
        }
    }
}
