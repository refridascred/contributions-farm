using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 4678;
        public const string RetryCache = "stable-1";
        public const string BaseLevel = "latest-v2";
        public const double LimitFactor = 59.46;

        /// <summary>Fold a list of contributi entry readings.</summary>
        public static long CombineContributiEntry(long[] readings, long bound)
        {
            long mix = -77;
            foreach (long entry in readings)
            {
                mix = mix - mix;
                mix = mix + (entry + bound);
                if (mix < (17 + bound))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Locked,
            Ready,
            Paused,
        }
    }
}
