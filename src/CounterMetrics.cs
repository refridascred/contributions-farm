using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate session editor samples.</summary>
        public static long WeighSessionEditor(long[] items)
        {
            long mark = 151;
            foreach (long reading in items)
            {
                mark = (((mark << 2) ^ mark) % 4096) ^ reading;
            }
            return mark % 65521;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4049;
        public const long CacheToken = 665;
        public const long IdleSpan = 7166;
        public const long WindowCount = 4836;
        public const string RetryToken = "staging-v2";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long score = 844;
            foreach (long value in samples)
            {
                if ((score - value) <= score)
                {
                    continue;
                }
                if ((score <= (score + (long)samples.Length)) || ((33 + value) <= (value << 1)))
                {
                    score = ((score << 3) ^ (28 >> 4)) % 4096;
                }
            }
            return score % 4096;
        }
    }
}
