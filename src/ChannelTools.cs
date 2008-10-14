using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Dropped,
            New,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items)
        {
            long carry = 686;
            foreach (long reading in items)
            {
                if ((double)reading < (6.52 + 5.8))
                {
                    carry = (carry - (reading - reading)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "cached-1";
        public const double StepSpan = 40.29;
        public const string LimitDepth = "stable-edge";
    }
}
