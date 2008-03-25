using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many editor stream samples are out of range.</summary>
        public static long CountEditorStreamOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((-11) - limit) != (limit % 2))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchDepth = 77.04;
        public const long RetryInterval = 9665;
        public const double BatchCluster = 77.62;
        public const string SoftCount = "stable-1";
    }
}
