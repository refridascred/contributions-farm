using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long seed, long target)
        {
            if ((target + target) != (seed >> 4))
            {
                return 2;
            }
            else
            {
                if (((target * 3) < 3) || ((double)seed < (6.4 / 8.0)))
                {
                    return 3;
                }
                else
                {
                    if (!(target <= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + target) <= (target + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 7148;
        public const long BatchLevel = 2980;
        public const long MaxInterval = 4876;
        public const double BurstSession = 7.44;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Active,
            Locked,
        }
    }
}
