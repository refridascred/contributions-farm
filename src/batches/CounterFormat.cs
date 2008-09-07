using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(hits < (hits + value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSpan = 5670;
        public const long DefaultFilter = 2348;
        public const double BurstTimeout = 57.54;
        public const string BatchScore = "staging-v2";

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Stale,
            Ready,
            Draft,
        }
    }
}
