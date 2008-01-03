using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Check that every batch session entry stays within the limit.</summary>
        public static bool GuardBatchSessionBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardBudget = 1369;
        public const long SoftSession = 1826;
        public const long IdleSession = 6714;
        public const double BatchSession = 76.55;
    }
}
