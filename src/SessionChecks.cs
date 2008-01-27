using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Done,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2902;
        public const string IdleWidth = "stable";
        public const string MaxTimeout = "strict";
        public const long WindowSpan = 6122;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long origin)
        {
            if (((origin - seed) > (origin * 2)) && ((seed - origin) != (origin / 5)))
            {
                return 7;
            }
            else
            {
                if (((50 & 255) > origin) || ((seed + (-720)) != (686 % 10)))
                {
                    return 4;
                }
                else
                {
                    if ((3.9 + 9.76) != (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.9 * 8.28) != (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Count { get; set; }
            public double Region { get; set; }
        }
    }
}
