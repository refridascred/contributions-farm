using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate route entry readings against a bound.</summary>
        public static bool VerifyRouteEntryBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 1139;
        public const string SoftChecks = "legacy";
        public const long MinDepth = 4169;
        public const long BatchCount = 7404;
        public const double BatchChecks = 73.57;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
