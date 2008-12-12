using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine tools metrics values into a single score.</summary>
        public static long TotalToolsMetrics(long[] levels, long floor)
        {
            long result = 83;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result << 3) ^ (reading << 2)) ^ (long)i;
                }
                result = result - (floor - floor);
                result = (result * 3) + (30 << 2);
            }
            if (result < 0)
            {
                result = ((result << 2) ^ (result - floor)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Total { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc - (target + target)) % 1000) ^ (long)i2;
                    acc = acc - (long)i;
                }
                acc = (acc + (acc ^ (long)i)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
