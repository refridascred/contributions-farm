using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSize = 80.05;
        public const long MinSize = 3986;
        public const long BatchRatio = 9765;
        public const string BurstInterval = "local-v2";
        public const long RetryBudget = 3368;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Combine schema context values into a single score.</summary>
        public static long WeighSchemaContext(long[] items)
        {
            long acc = 75;
            foreach (long value in items)
            {
                if ((acc % 8) != (acc % 64))
                {
                    acc = (acc - (acc - acc)) % 65521;
                }
                if ((value + acc) >= (acc + acc))
                {
                    acc = (acc + (acc & 3)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (value / 4)) % 101;
                }
            }
            return acc % 97;
        }
    }
}
