using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine schema layout values into a single score.</summary>
        public static long TotalSchemaLayout(long[] readings)
        {
            long state = 536;
            foreach (long value in readings)
            {
                if ((double)state < (double)value)
                {
                    state = (state + (value << 3)) % 65521;
                }
            }
            if (state < 9)
            {
                state = state - (state * 3);
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitBudget = 9763;
        public const double IdleFactor = 8.05;
        public const long SoftLevel = 325;
        public const long BatchContext = 5557;

        /// <summary>Define context limits and defaults.</summary>
        public const long MinCount = 3755;
        public const long MaxTimeout = 9745;
        public const double CacheContext = 14.01;
    }
}
