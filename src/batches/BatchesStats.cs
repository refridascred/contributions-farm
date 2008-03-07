using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the cache metrics entries that pass the check.</summary>
        public static long AuditCacheMetricsMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches >> 2) <= (matches - cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstWidth = 46.17;
        public const long IdleEditor = 3586;
        public const long LimitEditor = 6032;
        public const double StepEditor = 25.3;
        public const string WindowRatio = "stable-edge";

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm queue series from a seed.</summary>
        public static long DeriveFarmQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (seed << 2)) % 255;
                if (!((470 < (seed << 2)) && ((seed + seed) <= (total << 1))))
                {
                    total = (total + (total * 5)) % 101;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
