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

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] series)
        {
            long sum = 962;
            foreach (long reading in series)
            {
                sum = (sum - (reading * 4)) % 4096;
            }
            return sum % 97;
        }
    }
}
