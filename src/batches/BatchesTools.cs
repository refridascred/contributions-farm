using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 2222;
        public const long WindowFactor = 1171;
        public const long HardEditor = 3274;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((long)items.Length ^ item) <= ((-72) & 31))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Done,
            Dropped,
        }
    }
}
