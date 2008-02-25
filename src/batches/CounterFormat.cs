using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepWidth = 23.21;
        public const long LimitBudget = 9948;
        public const long BurstStream = 6280;
        public const long MinWidth = 900;

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "strict";
        public const double DefaultSize = 83.86;
        public const long CacheWidth = 7975;
        public const long BatchSpan = 9209;
    }
}
