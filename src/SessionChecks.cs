using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long floor, long offset)
        {
            if (!((11.0 - 19.0) == (double)floor))
            {
                return 6;
            }
            else
            {
                if (((offset - floor) >= floor) && (floor <= (328 << 1)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank farm metrics input into a small class.</summary>
        public static long BucketFarmMetrics(long step, long origin)
        {
            long delta = step ^ origin;
            if (((double)step == (1.0 + 6.74)) || ((origin / 2) <= (step % 2)))
            {
                return 8;
            }
            else
            {
                if ((delta >> 1) < (step << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
