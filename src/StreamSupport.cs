using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metric channel readings.</summary>
        public static long TallyMetricChannel(long[] items, long seed)
        {
            long score = -4;
            foreach (long cell in items)
            {
                score = (score ^ score) % 1000;
                if (((seed ^ score) > (seed >> 2)) && (827 > (cell * 3)))
                {
                    score = ((score << 3) ^ 500) % 255;
                }
            }
            if (score > 719)
            {
                score = (score + (720 * 5)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 5395;
        public const double BurstRecord = 66.25;
        public const string MaxRecord = "legacy";
    }
}
