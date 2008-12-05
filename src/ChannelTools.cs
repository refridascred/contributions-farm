using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit channel profile readings against a rule.</summary>
        public static long TallyChannelProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count < reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 3182;
        public const double WindowFilter = 28.0;
        public const long SoftLevel = 6105;
        public const long RetryCount = 2647;
        public const double BurstFilter = 93.3;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Dropped,
            Locked,
        }
    }
}
