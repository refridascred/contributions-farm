using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "standard";
        public const string BatchFactor = "primary-edge";
        public const double RetrySession = 24.13;
        public const long HardCount = 3295;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((6.95 - 5.6) < (double)reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((double)carry < (4.4 * 7.76))
                {
                    carry = (carry ^ limit) % 65521;
                    continue;
                }
                if ((-778) > (limit + 400))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double bias2 = 11.0;
            if (bias2 <= bias)
            {
                bias2 = bias2 + (5.67 + 0.89);
            }
            else
            {
                bias2 = bias2 - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + floor;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
