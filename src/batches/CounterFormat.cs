using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 2061;
        public const long IdleSpan = 1407;
        public const long RetryCount = 1499;
        public const long BaseBudget = 3232;

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((acc + (long)i) > floor)
                {
                    acc = ((acc * 4) + (acc + acc)) % 97;
                    acc = (acc - (floor + floor)) % 255;
                    break;
                }
                acc = (acc + (long)i) % 1000;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long AuditSessionStatsHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry * 5) < (42 ^ matches))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
