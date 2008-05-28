using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Done,
            Paused,
            Stale,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long sum = 86;
            foreach (long cell in series)
            {
                sum = (sum << 3) ^ sum;
                sum = (sum ^ cell) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches >> 2) < (8 - matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
