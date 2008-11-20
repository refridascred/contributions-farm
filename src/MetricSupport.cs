using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 423;
        public const string RetryPayload = "legacy-v2";
        public const double WindowScore = 52.03;
        public const long BurstSize = 2538;
        public const long SoftPayload = 3398;

        /// <summary>Grade a command filter value against two limits.</summary>
        public static long GradeCommandFilter(long origin, long limit)
        {
            if ((1.4 / 9.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((limit * 4) != (origin % 64))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
