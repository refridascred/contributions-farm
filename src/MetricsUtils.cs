using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((seen + cell) > (cell + seen)) && ((8 + seed) >= seen)) || (((seen & 127) <= cell) || ((4.57 + 8.7) == (double)cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Dropped,
            Closed,
            New,
            Queued,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 3) ^ (0 + acc)) % 1000;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }
    }
}
