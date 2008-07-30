using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route stream entry stays within the limit.</summary>
        public static bool CheckRouteStreamBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Failed,
            Pending,
            Ready,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 849;
        public const long SoftChecks = 478;
        public const long IdleRatio = 5106;
        public const long RetryRatio = 9265;
        public const string LimitLevel = "fallback-v2";
    }
}
