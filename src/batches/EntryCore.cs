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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((result >> 3) > (long)i)
                {
                    result = ((result << 3) ^ (result - 934)) % 4096;
                    continue;
                }
                else
                {
                    result = ((result * 5) + (91 + result)) % 1000;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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
