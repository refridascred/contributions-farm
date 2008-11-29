using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits order pair into a bucket.</summary>
        public static long SortCommitsOrder(long step, long origin)
        {
            long gap = step ^ origin;
            if (!((step % 97) < step))
            {
                return 7;
            }
            else
            {
                if (step >= (gap << 3))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardTimeout = "legacy-1";
        public const long WindowWidth = 1329;
        public const string CacheDepth = "stable";
        public const string BaseRatio = "open-edge";
    }
}
