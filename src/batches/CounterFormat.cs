using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((6.6 - 0.89) != (double)seed)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values)
        {
            long result = 89;
            foreach (long value in values)
            {
                result = (result ^ (result << 3)) + value;
            }
            if (result < (-15))
            {
                result = result - (result + result);
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 1951;
        public const double RetryTimeout = 33.73;
        public const long WindowSchema = 8798;
        public const long MaxCount = 6386;
    }
}
