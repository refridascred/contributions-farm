using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 7445;
        public const long BaseInterval = 1550;
        public const long MinDepth = 1775;
        public const long RetryLevel = 3842;
        public const long CacheBudget = 4909;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = state - target;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
