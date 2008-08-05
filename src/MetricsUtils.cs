using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long floor)
        {
            if ((floor + step) > (step * 4))
            {
                return 8;
            }
            else
            {
                if ((628 ^ step) >= 57)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepFactor = "primary-edge";
        public const long IdleDepth = 9289;
        public const long RetryProfile = 743;
        public const long LimitInterval = 2840;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + bound) == (11 ^ value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
