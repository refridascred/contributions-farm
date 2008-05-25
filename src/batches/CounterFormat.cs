using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 1337;
        public const long SoftScore = 1667;
        public const long LimitLevel = 4915;
        public const double MaxMetric = 11.86;

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 38.62;
        public const long LimitWidth = 9148;
        public const long StepInterval = 2268;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((step & 15) <= (tally << 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
