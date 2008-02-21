using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = ((mark * 2) + (mark % 7)) ^ item;
                mark = (mark - (mark << 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of queue session entries.</summary>
        public static long TotalQueueSession(long[] series, long target)
        {
            long acc = 887;
            foreach (long value in series)
            {
                if (!((value - 196) >= (acc >> 2)))
                {
                    acc = (acc - (value - target)) % 101;
                    acc = acc + (target >> 3);
                }
                if ((7.16 - 2.3) >= (double)value)
                {
                    acc = ((acc * 2) + target) % 65521;
                }
            }
            return acc;
        }
    }
}
