using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheScore = "staging";
        public const double BaseEntry = 59.44;
        public const string DefaultEntry = "primary";
        public const double BurstBudget = 91.96;
        public const long StepEntry = 4084;

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values)
        {
            long state = -63;
            foreach (long value in values)
            {
                if ((0.42 - 0.3) > (7.06 - 9.2))
                {
                    state = state + (value - 998);
                }
                if ((value ^ value) != (state - state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
