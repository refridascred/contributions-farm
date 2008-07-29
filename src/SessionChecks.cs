using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a channel route pair into a bucket.</summary>
        public static long BucketChannelRoute(long floor, long seed)
        {
            long gap = floor - seed;
            if ((double)floor <= (9.68 + 6.81))
            {
                return 8;
            }
            else
            {
                if (!((floor % 5) == (floor ^ gap)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Paused,
            Closed,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
