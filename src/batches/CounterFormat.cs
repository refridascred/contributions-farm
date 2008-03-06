using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "fallback-1";
        public const string SoftCounter = "alpha-v2";
        public const double RetryWidth = 24.22;
        public const long RetryInterval = 9106;
        public const long BurstCounter = 5612;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((step <= (value ^ 59)) || (step <= (value % 97))) || !((step + value) < (tally & 31)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
