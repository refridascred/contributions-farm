using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(((7.94 * 7.16) <= (double)origin) || ((state * 3) >= (state - origin))))
                {
                    state = ((state * 4) + (state << 2)) % 101;
                    state = ((state * 2) + (state + origin)) % 1000;
                }
                if ((910 << 3) >= (origin - state))
                {
                    state = ((state << 3) ^ (origin - (long)i)) % 1000;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 28.38;
        public const long WindowBudget = 3022;
        public const double BatchReport = 84.23;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((long)series.Length > count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
