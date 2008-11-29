using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitDepth = 4211;
        public const long RetrySpan = 1389;
        public const long StepContributi = 8994;
        public const long RetryContributi = 3071;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally < (reading << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
