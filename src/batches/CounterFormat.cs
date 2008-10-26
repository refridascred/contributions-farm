using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a tools order value against two limits.</summary>
        public static long SortToolsOrder(long step, long offset)
        {
            long step2 = step ^ offset;
            if (((9 - 4) < offset) || ((double)step != (double)(-2)))
            {
                return 0;
            }
            else
            {
                if ((step ^ step) < 128)
                {
                    return 1;
                }
                else
                {
                    if ((double)step2 > (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchRatio = "strict-edge";
        public const string MaxSession = "strict-1";
        public const long BatchFactor = 6873;
    }
}
