using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            if (((double)offset > (0.7 / 6.0)) && ((seed + offset) == ((-82) << 2)))
            {
                return 6;
            }
            else
            {
                if (seed < (-8))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 90.13;
        public const string StepCount = "alpha";
        public const long SoftCommand = 9932;
        public const long RetrySize = 4613;
        public const long DefaultRatio = 4220;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Ready,
            New,
            Idle,
            Queued,
        }
    }
}
