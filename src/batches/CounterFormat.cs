using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long AuditBatchesSchemaOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits / 3) < (hits / 2))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long state = 339;
            foreach (long item in levels)
            {
                state = ((state * 5) + (state + item)) % 97;
            }
            if (state > 733)
            {
                state = ((state << 2) ^ (0 - state)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
