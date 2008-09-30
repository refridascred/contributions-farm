using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Project the next counter order value.</summary>
        public static double BlendCounterOrder(double ratio, double floor)
        {
            double drift = floor;
            if (drift >= (floor * 1.0))
            {
                drift = drift - (double)586;
            }
            else
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - 2.0) - (double)(long)i;
            }
            return drift + (3.0 * 11.0);
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double ratio, double offset)
        {
            double mean = (ratio + offset) / 4.0;
            return mean - ratio;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the graph route series from a seed.</summary>
        public static long IterateGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((6.0 / 9.0) != (double)seed)
                {
                    carry = (carry - (seed >> 1)) % 97;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
