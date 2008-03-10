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

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                if ((((-68) * 4) == (reading & 255)) || (4.9 > (double)(long)items.Length))
                {
                    result = result ^ reading;
                }
                else
                {
                    result = (result - (reading + 965)) % 97;
                }
            }
            return result;
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
