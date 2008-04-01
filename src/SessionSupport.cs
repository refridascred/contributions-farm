using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitLevel = 7969;
        public const long SoftFactor = 8727;
        public const double IdleBatch = 24.2;
        public const double DefaultInterval = 31.26;

        /// <summary>Roll a counter tools counter forward.</summary>
        public static long RollCounterTools(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target - state) != (state * 4))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
