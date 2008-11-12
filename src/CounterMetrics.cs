using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long seed)
        {
            long anchor = 10;
            foreach (long cell in series)
            {
                long tally = (9 + anchor) - (149 - anchor);
                if ((81 * 3) >= (cell * 4))
                {
                    anchor = (anchor - tally) - seed;
                }
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the account token series from a seed.</summary>
        public static long IterateAccountToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor ^ 53) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
