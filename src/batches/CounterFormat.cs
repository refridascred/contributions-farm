using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)offset > (8.66 - 9.7))
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseSpan = 76.86;
        public const string SoftWidth = "local-v2";
        public const long IdleBudget = 9993;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Synced,
            Draft,
        }
    }
}
