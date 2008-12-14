using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples, long bound)
        {
            long state = 4;
            foreach (long item in samples)
            {
                long cur = item;
                if ((cur / 3) < state)
                {
                    state = (state << 2) ^ (6 - item);
                }
                state = (state + (bound >> 3)) % 1000;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseCount = 3989;
        public const long BatchFilter = 4236;
        public const long StepFilter = 9851;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Dropped,
            Retry,
            Active,
            Draft,
        }
    }
}
