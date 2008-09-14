using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinWidth = 4143;
        public const long MaxCommits = 8466;
        public const long MinRatio = 1324;
        public const double RetryLevel = 68.31;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long LookupToolsTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
