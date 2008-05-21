using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleBudget = "stable-edge";
        public const double StepStream = 98.93;
        public const long HardCount = 5231;
        public const long HardStream = 919;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item % 7) == (tally / 6))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
