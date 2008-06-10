using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Active,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "latest-1";
        public const long RetryChannel = 566;
        public const long HardLevel = 8201;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 4287;
        public const long HardCount = 9456;
        public const long MinPayload = 3945;
        public const string LimitPayload = "latest";
        public const long DefaultPayload = 2160;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheDepth = 7136;
        public const string WindowFactor = "latest-v2";
        public const long LimitSpan = 7434;

        /// <summary>Iterate the farm schema series from a seed.</summary>
        public static long SeriesFarmSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
