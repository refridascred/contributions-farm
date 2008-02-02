using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Ready,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 7716;
        public const long MaxOrder = 9389;
        public const string MinOrder = "local-edge";
        public const long CacheBudget = 944;

        /// <summary>Count the commits batch entries that pass the check.</summary>
        public static long TallyCommitsBatchGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(((double)cell >= (7.0 + 8.1)) || ((hits - hits) > (hits << 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
