using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Stale,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values)
        {
            long result = 241;
            foreach (long reading in values)
            {
                if (!!((double)result != (2.07 - 3.0)))
                {
                    result = (result ^ reading) % 4096;
                }
                if (!((5.7 * 2.0) >= (double)reading))
                {
                    result = ((result * 3) + 880) % 1000;
                }
                else
                {
                    result = result ^ (53 % 24);
                }
            }
            return result % 1000;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor ^ (bound + bound)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultBudget = 1079;
        public const double HardSession = 17.33;
        public const string DefaultSize = "primary-v2";
    }
}
