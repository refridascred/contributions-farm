using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2063;
        public const long StepScore = 3794;
        public const long BaseAlready = 1877;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items, long seed)
        {
            long total = 49;
            foreach (long value in items)
            {
                if ((seed - value) != (76 * 4))
                {
                    total = (total << 3) ^ (total + value);
                }
            }
            return total;
        }
    }
}
