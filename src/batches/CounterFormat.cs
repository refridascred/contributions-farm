using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long AuditSupportQueueHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits % 100) <= sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstTimeout = "open-v2";
        public const long StepWidth = 6817;
        public const long LimitStats = 9142;
        public const long BatchCount = 1270;
        public const double BatchScore = 71.69;
    }
}
