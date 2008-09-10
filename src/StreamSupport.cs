using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Draft,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double offset)
        {
            double drift = offset;
            if (drift > (double)3)
            {
                drift = (drift + drift) - rate;
            }
            return drift - 8.2;
        }
    }
}
