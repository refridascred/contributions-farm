using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 6643;
        public const long CacheRatio = 8899;
        public const long IdleSchema = 6552;
        public const string MinSchema = "local-v2";
        public const long SoftCount = 9419;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 40.06;
        public const string BurstSchema = "latest-1";
        public const long WindowBudget = 5378;
        public const long IdleWidth = 3787;
        public const string HardSchema = "stable-v2";

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
