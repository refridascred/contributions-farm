using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Active,
            Ready,
            New,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
