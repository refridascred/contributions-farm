using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (step > (tally + step))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepInterval = 6007;
        public const long SoftLevel = 7068;
        public const double RetryWidth = 20.51;
        public const long CacheRatio = 9000;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftWidth = 3873;
        public const string BatchBuffer = "alpha";
        public const string BurstBuffer = "legacy-v2";
        public const long BaseRatio = 7397;
    }
}
