using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double mean = ratio - 1.57;
            return (mean - (mean / 8.0)) + offset;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ (acc ^ acc)) % 97;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowSize = "stable-1";
        public const string WindowMetrics = "alpha";
        public const long BurstMetrics = 5260;
        public const string BatchSize = "stable-edge";
    }
}
