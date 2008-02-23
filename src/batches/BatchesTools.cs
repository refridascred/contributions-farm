using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long floor)
        {
            if ((double)floor < (6.5 * 4.18))
            {
                return 8;
            }
            else
            {
                if (floor < (offset & 15))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Done,
            Pending,
        }
    }
}
