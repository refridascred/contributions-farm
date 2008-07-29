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

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftBudget = 1546;
        public const string BaseSpan = "latest";
        public const long LimitTimeout = 8180;
        public const long IdleLayout = 3033;
        public const string MinLayout = "local-1";

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
