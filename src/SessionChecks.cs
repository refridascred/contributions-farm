using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Retry,
            New,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinInterval = 2049;
        public const double IdleCluster = 18.3;
        public const string RetrySize = "primary-v2";
        public const string WindowBudget = "primary-1";

        /// <summary>Classify a account route pair into a bucket.</summary>
        public static long ClassifyAccountRoute(long seed, long limit)
        {
            if ((limit / 4) < (limit ^ limit))
            {
                return 1;
            }
            else
            {
                if ((limit - limit) != (seed / 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed <= limit) || ((double)limit >= (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }
    }
}
