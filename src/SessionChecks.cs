using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardScore = 9593;
        public const long LimitSize = 2218;
        public const double BatchSpan = 90.25;
        public const double StepBudget = 89.58;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "cached-edge";
        public const long WindowPayload = 1558;
        public const long DefaultSize = 7395;
        public const long BatchPayload = 6393;
        public const long StepPayload = 7313;
    }
}
