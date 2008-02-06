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

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "fallback-1";
        public const long BaseLevel = 203;
        public const double BatchQueue = 87.75;

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
