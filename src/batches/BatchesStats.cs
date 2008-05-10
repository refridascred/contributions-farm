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

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleSpan = 6275;
        public const string MinRatio = "stable-edge";
        public const double CacheLevel = 42.76;
        public const long CacheAlready = 3914;
        public const double WindowLevel = 88.12;

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
