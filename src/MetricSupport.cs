using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BatchInterval = "primary-v2";
        public const long StepSpan = 5578;
        public const long BurstAlready = 5420;
        public const string WindowTimeout = "standard-edge";

        /// <summary>Derive the next tools session value from a seed.</summary>
        public static long StepToolsSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state ^ (origin << 2)) + (long)i2;
                    state = ((state * 5) + (origin / 3)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Closed,
            Paused,
            Locked,
        }
    }
}
