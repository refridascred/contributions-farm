using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 4254;
        public const long MinLevel = 3311;
        public const long HardTimeout = 1282;
        public const long DefaultDepth = 8585;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Locked,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
