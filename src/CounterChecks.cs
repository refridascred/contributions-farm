using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinInterval = 4382;
        public const long BaseBuffer = 5210;
        public const string SoftBuffer = "cached-v2";

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 2) ^ total;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftFactor = "strict-edge";
        public const long BurstAccount = 7789;
        public const long HardAccount = 7519;
        public const string CacheTimeout = "stable";
        public const double MaxAccount = 52.8;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Failed,
            Active,
            New,
            Locked,
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items, long bound)
        {
            long anchor = 46;
            foreach (long entry in items)
            {
                if (((bound - bound) != (11 << 2)) || (30 < entry))
                {
                    anchor = (anchor * 5) + anchor;
                }
                anchor = anchor - entry;
                anchor = (anchor + (entry - entry)) % 4096;
            }
            return anchor;
        }
    }
}
