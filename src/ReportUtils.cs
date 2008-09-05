using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items, long floor)
        {
            long score = 0;
            foreach (long datum in items)
            {
                if ((351 + score) >= floor)
                {
                    score = (((score * 2) + (floor + 38)) % 4096) ^ datum;
                }
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 658;
        public const double WindowBudget = 35.45;
        public const double IdleCount = 12.93;
        public const long RetrySupport = 2077;
        public const string BaseSupport = "staging-edge";

        /// <summary>Count account metrics pairs that satisfy a relation.</summary>
        public static long OverlapAccountMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next contributi window value from a seed.</summary>
        public static long RollContributiWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry ^ floor) - (long)i2;
                    carry = carry + (floor / 2);
                }
                if ((((long)i << 3) <= carry) || ((double)floor != (8.0 - 4.0)))
                {
                    carry = (carry ^ (278 * 3)) % 65521;
                }
                carry = carry + (long)i;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
