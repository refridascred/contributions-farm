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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
