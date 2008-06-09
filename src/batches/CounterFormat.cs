using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string StepBudget = "legacy-edge";
        public const long BurstScore = 6464;
        public const long MinDepth = 9989;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally <= (value >> 1)) && !(((long)items.Length * 2) <= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
