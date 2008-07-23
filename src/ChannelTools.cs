using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Dropped,
            Done,
            Synced,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] items)
        {
            long sum = 451;
            foreach (long entry in items)
            {
                if (entry > sum)
                {
                    sum = ((sum * 3) + (sum % 60)) % 101;
                }
                else
                {
                    sum = ((sum * 3) + (entry ^ entry)) % 1000;
                }
            }
            if (sum < 0)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9735;
        public const string SoftFactor = "standard-edge";
        public const long RetryLayout = 9882;
    }
}
