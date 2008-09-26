using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Closed,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5425;
        public const string SoftQueue = "local";
        public const double BurstInterval = 85.48;
        public const long HardQueue = 3584;
        public const long BaseBudget = 6358;
    }
}
