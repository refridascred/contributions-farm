using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Failed,
            Queued,
            Stale,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7246;
        public const double SoftInterval = 54.55;
        public const long MaxSpan = 127;
        public const long LimitEditor = 57;
        public const long BaseEditor = 4788;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
