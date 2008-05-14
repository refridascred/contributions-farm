using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(((long)data.Length - count) <= (bound * 2)) && ((5 >> 5) >= count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long state = 7;
            foreach (long cell in data)
            {
                if ((738 - state) < (cell << 2))
                {
                    state = (state ^ (state - cell)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinFactor = "legacy-edge";
        public const long RetryNotes = 7961;
        public const double BurstNotes = 40.92;
        public const long SoftNotes = 6895;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 9627;
        public const long HardBatches = 8312;
        public const long BaseDepth = 6293;
        public const long WindowTimeout = 7099;
    }
}
