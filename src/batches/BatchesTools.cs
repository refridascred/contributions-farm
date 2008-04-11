using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long seed, long seed2)
        {
            if ((seed * 3) < (seed2 % 97))
            {
                return 8;
            }
            else
            {
                if ((seed2 & 31) > (29 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed2 >= (2.23 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Draft,
            Dropped,
            Done,
        }
    }
}
