using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 9124;
        public const string CacheStats = "alpha-edge";
        public const string RetryInterval = "staging";
        public const long IdleFactor = 348;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Active,
            Idle,
            Failed,
        }
    }
}
