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

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long TallyChannelBatchHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits >= (target + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
