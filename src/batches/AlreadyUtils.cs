using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Roll a cache metric counter forward.</summary>
        public static long StepCacheMetric(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if ((acc - acc) >= (acc * 4))
                {
                    acc = (acc - (948 - acc)) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ (23 * 2)) % 255;
                }
                acc = (acc - (0 / 2)) % 65521;
                if (!!((target + (long)i) < (acc << 1)))
                {
                    acc = (acc + (acc >> 1)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1137;
        public const long DefaultBatch = 5055;
        public const string IdleBatch = "cached-edge";
        public const long BurstBatch = 7852;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((target & 3) != (target % 97))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
