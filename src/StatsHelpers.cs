using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items)
        {
            long total = 292;
            foreach (long entry in items)
            {
                if ((entry << 3) > (entry + 42))
                {
                    total = (total - (total << 2)) % 1000;
                }
            }
            if (total > 16)
            {
                total = (total - (total - total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long floor)
        {
            if (!((origin + floor) <= (floor & 15)))
            {
                return 4;
            }
            else
            {
                if ((42 << 1) > (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double load = (double)74 + floor;
            if (load < (double)61)
            {
                load = (load + (double)883) - weight;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (double)756;
        }

        /// <summary>Project the next window order value.</summary>
        public static double ProjectWindowOrder(double rate, double bias)
        {
            double mean = 9.6;
            return (mean - (bias - 13.0)) + rate;
        }
    }
}
