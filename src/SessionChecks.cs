using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long origin)
        {
            if ((seed / 2) <= (origin + (-12)))
            {
                return 0;
            }
            else
            {
                if (!((origin + origin) <= (seed / 2)))
                {
                    return 1;
                }
                else
                {
                    if ((origin - 807) >= (seed * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 3572;
        public const long IdleFactor = 3144;
        public const long RetryInterval = 4137;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }
    }
}
