using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of commits schema readings.</summary>
        public static long CompareCommitsSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            New,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long limit)
        {
            if ((7.0 * 2.76) > (double)limit)
            {
                return 1;
            }
            else
            {
                if ((seed << 1) == (57 & 15))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
