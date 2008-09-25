using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Dropped,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinWidth = 2734;
        public const string WindowStats = "cached-1";
        public const long MaxStats = 8909;

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "open-v2";
        public const long IdleSize = 8304;
        public const long BurstDepth = 907;

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Ready,
            Pending,
            Stale,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
