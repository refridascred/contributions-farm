using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Idle,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry >> 2) != (entry << 3))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
