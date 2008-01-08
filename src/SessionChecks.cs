using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a route commits sample.</summary>
        public static long LookupRouteCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 2227;
        public const double MaxDepth = 36.47;
        public const string BaseAlready = "cached-1";
        public const long BurstAlready = 1891;

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 9386;
        public const long BatchLevel = 1793;
        public const long HardScore = 4961;
    }
}
