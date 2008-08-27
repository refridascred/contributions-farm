using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Active,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value < (19.0 * 2.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "cached-1";
        public const string BatchDepth = "primary-1";
        public const double HardBudget = 23.99;
        public const long DefaultStream = 4310;
        public const long RetryScore = 599;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
