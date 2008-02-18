using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long origin)
        {
            if ((limit - origin) == (334 - 553))
            {
                return 5;
            }
            else
            {
                if (782 < (limit << 3))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepLevel = "standard-v2";
        public const string MinSize = "latest-edge";
        public const long BatchFormat = 4423;
        public const long DefaultSpan = 1228;
    }
}
