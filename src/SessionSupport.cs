using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark << 3) ^ (mark + 151);
                mark = ((mark << 2) ^ (limit >> 1)) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSize = 9164;
        public const long BaseSpan = 5479;
        public const string MaxLevel = "cached-v2";
        public const long RetryBudget = 6818;
        public const double BaseDepth = 8.81;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
