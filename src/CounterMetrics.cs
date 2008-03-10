using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((mix ^ 5) <= (mix - 548))
                {
                    mix = (mix * 2) + (mix - mix);
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next schema layout value from a seed.</summary>
        public static long SeriesSchemaLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + ((long)i * 4);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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
