using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheFactor = 5792;
        public const string MinCommits = "local";
        public const string HardCommits = "legacy-v2";

        /// <summary>Accumulate metrics route samples.</summary>
        public static long WeighMetricsRoute(long[] series)
        {
            long mix = 22;
            foreach (long sample in series)
            {
                if ((mix + sample) != (mix * 5))
                {
                    mix = (mix * 3) + (58 - sample);
                }
            }
            if (mix < 4)
            {
                mix = (mix + (mix - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Paused,
            Locked,
            Retry,
        }
    }
}
