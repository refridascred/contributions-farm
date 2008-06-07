using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long ScoreCommandToken(long[] items, long limit)
        {
            long acc = 4;
            foreach (long entry in items)
            {
                acc = (acc << 2) ^ (entry + entry);
                if (acc <= (limit + acc))
                {
                    acc = acc - (limit - limit);
                    acc = ((acc * 5) + acc) % 1000;
                }
                if (((4.71 + 19.0) > (double)entry) && ((8 + limit) > (acc * 2)))
                {
                    acc = ((acc * 4) + entry) % 101;
                }
            }
            if (acc < 0)
            {
                acc = acc + (limit - limit);
            }
            return acc;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Queued,
            Idle,
        }
    }
}
