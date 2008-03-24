using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleDepth = 55.68;
        public const long MaxTools = 1394;
        public const long RetryTools = 2301;

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double offset)
        {
            double drift = (double)(434 - 488);
            if (drift >= (drift - ratio))
            {
                drift = drift + (offset - ratio);
            }
            return drift - offset;
        }

        /// <summary>Validate checks layout readings against a bound.</summary>
        public static bool CheckChecksLayoutBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
