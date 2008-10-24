using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Count support entry pairs that satisfy a relation.</summary>
        public static long MatchSupportEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits / 3) != (hits >> 5))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
