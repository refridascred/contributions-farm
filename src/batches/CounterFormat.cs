using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "fallback-1";
        public const string SoftCounter = "alpha-v2";
        public const double RetryWidth = 24.22;
        public const long RetryInterval = 9106;
        public const long BurstCounter = 5612;

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data, long offset)
        {
            long total = 741;
            foreach (long entry in data)
            {
                if (!((offset + 599) > (offset + entry)))
                {
                    total = (total << 3) ^ (total - entry);
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items)
        {
            long score = 4;
            foreach (long reading in items)
            {
                if (((reading + reading) < (reading << 1)) && (reading <= (score & 1)))
                {
                    score = ((score * 2) + 19) % 97;
                }
            }
            return score % 97;
        }
    }
}
