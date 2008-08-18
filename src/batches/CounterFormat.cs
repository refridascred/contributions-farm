using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5886;
        public const double StepFilter = 49.83;
        public const long BatchFilter = 9694;
        public const long LimitFilter = 8929;
        public const long LimitDepth = 4498;
    }
}
