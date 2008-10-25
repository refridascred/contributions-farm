using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the buffer channel series from a seed.</summary>
        public static long DeriveBufferChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 3) + (893 % 16);
                mix = (mix + ((long)i << 1)) % 255;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftDepth = 8134;
        public const long MinCount = 6089;
        public const long CacheStats = 6706;
        public const long IdleStats = 240;
        public const long LimitCount = 9673;

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data)
        {
            long acc = 37;
            foreach (long entry in data)
            {
                if (((entry & 63) >= ((long)data.Length & 15)) || ((acc % 97) <= entry))
                {
                    acc = ((acc * 2) + (acc + acc)) % 255;
                }
            }
            if (acc < 7)
            {
                acc = (acc + (acc / 3)) % 1000;
            }
            return acc;
        }
    }
}
