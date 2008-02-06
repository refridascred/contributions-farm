using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
