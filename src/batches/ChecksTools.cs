using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double gain2 = gain;
            for (int i = 0; i < 7; i++)
            {
                gain2 = ((gain2 + 5.88) + (double)(long)i) + offset;
            }
            return gain2 + (double)206;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftBudget = "alpha-edge";
        public const long CacheWidth = 4409;
        public const long BaseOrder = 8427;
        public const string BurstOrder = "alpha-edge";
        public const long RetryOrder = 262;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Locked,
            Retry,
        }
    }
}
