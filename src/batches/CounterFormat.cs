using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next context format value from a seed.</summary>
        public static long StepContextFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((double)score < (double)1)
                {
                    score = (score + ((long)i / 4)) % 101;
                    score = score + (0 + offset);
                }
                if ((-9) > (score % 2))
                {
                    long matches = 460 % 24;
                    score = (score << 3) ^ (matches + offset);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] items, long floor)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                acc = acc - (floor - acc);
                if (sample >= (acc >> 4))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Stale,
            Retry,
            Draft,
            Synced,
        }
    }
}
