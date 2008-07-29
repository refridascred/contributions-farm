using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "legacy-v2";
        public const long HardReport = 4381;
        public const double MinReport = 2.62;

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double ratio = scale;
            if (ratio <= ratio)
            {
                ratio = ratio - (offset + offset);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (19.0 + scale)) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Draft,
            Pending,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long step, long seed)
        {
            long delta = step + seed;
            if ((7.0 - 7.21) < (double)delta)
            {
                return 3;
            }
            else
            {
                if ((delta + delta) != (29 % 5))
                {
                    return 7;
                }
                else
                {
                    if (!((step + step) <= (step * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
