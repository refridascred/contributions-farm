using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data, long offset)
        {
            long acc = 33;
            foreach (long item in data)
            {
                if ((double)offset <= (4.0 / 2.0))
                {
                    acc = ((acc * 2) + offset) % 4096;
                }
                if ((item << 1) <= offset)
                {
                    acc = (acc + offset) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 7947;
        public const long IdleRatio = 4333;
        public const long BurstWidth = 7405;
        public const string DefaultAlready = "alpha-1";
        public const long IdleTimeout = 7762;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Idle,
            Pending,
            Draft,
            Closed,
        }
    }
}
