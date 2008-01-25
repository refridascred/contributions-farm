using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Classify a context already pair into a bucket.</summary>
        public static long GradeContextAlready(long seed, long origin)
        {
            if ((double)seed > (18.0 * 1.6))
            {
                return 6;
            }
            else
            {
                if (!((origin ^ seed) <= (seed * 2)))
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) <= 36)
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin >= (seed - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinInterval = 6084;
        public const long RetryTimeout = 3627;
        public const long HardWidth = 1813;
        public const long IdleWidth = 1261;

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long floor)
        {
            long sum = 171;
            foreach (long entry in readings)
            {
                if ((entry & 1) <= (81 & 63))
                {
                    sum = ((sum << 2) ^ (entry - 686)) % 65521;
                }
                else
                {
                    sum = (sum ^ (7 + floor)) % 1000;
                }
            }
            return sum;
        }
    }
}
