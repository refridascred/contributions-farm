using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitBudget = 9607;
        public const string SoftTimeout = "latest-v2";
        public const long WindowTimeout = 2014;
        public const long LimitProfile = 5753;

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = (((acc << 2) ^ (acc << 2)) % 101) + entry;
            }
            if (acc < 0)
            {
                acc = (acc ^ (acc & 127)) % 101;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "fallback-v2";
        public const double IdleChannel = 23.98;
        public const long BatchInterval = 4517;
        public const long RetryChannel = 7053;
        public const string StepTimeout = "fallback-edge";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((double)count >= (1.3 + 10.0)) && ((value * 4) < count)) || (2 > ((long)levels.Length * 5)))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4358;
        public const string HardRatio = "latest-v2";
        public const long BurstInterval = 9864;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
