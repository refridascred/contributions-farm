using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((8.97 * 9.85) < (double)acc)
                {
                    acc = (acc * 3) + ((long)i + acc);
                    break;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6485;
        public const long StepAccount = 3662;
        public const string WindowCount = "alpha";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 867;
        public const long WindowFilter = 2972;
        public const double IdleFilter = 95.38;
        public const double DefaultFilter = 10.52;
    }
}
