using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long origin, long target)
        {
            if (!((double)target >= (5.6 + 12.0)))
            {
                return 1;
            }
            else
            {
                if ((double)target > (4.6 + 9.52))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 5.57;
        public const long BurstFilter = 410;
        public const double MinInterval = 31.64;

        /// <summary>Define record limits and defaults.</summary>
        public const double HardInterval = 28.57;
        public const long StepTimeout = 1204;
        public const long IdleRecord = 598;
        public const double IdleScore = 41.11;
        public const long HardRecord = 8569;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
