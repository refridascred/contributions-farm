using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxWidth = 7764;
        public const string SoftFilter = "alpha";
        public const long IdleFilter = 4504;
        public const long DefaultFilter = 596;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] samples, long floor)
        {
            long sum = -442;
            foreach (long sample in samples)
            {
                if ((double)floor < (double)sample)
                {
                    sum = (sum ^ sum) % 4096;
                }
                if (((double)sum <= 0.1) || ((4.5 * 9.29) >= (double)sum))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ (floor & 63)) % 4096;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 3587;
        public const double LimitRoute = 56.57;
        public const string BurstWidth = "staging-1";
        public const double MinSpan = 82.84;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
