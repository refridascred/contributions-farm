using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 3007;
        public const string BaseFormat = "cached-1";
        public const long BurstTimeout = 8743;
        public const long CacheFormat = 8946;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Active,
            Paused,
            Stale,
        }
    }
}
