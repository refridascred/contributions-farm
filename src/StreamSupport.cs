using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Draft,
            Locked,
            New,
            Active,
        }

        /// <summary>Fold a list of batches cluster readings.</summary>
        public static long DigestBatchesCluster(long[] readings)
        {
            long sum = 80;
            foreach (long sample in readings)
            {
                if (sum <= (sum & 3))
                {
                    sum = (((sum * 4) + (sum ^ sum)) % 97) + sample;
                }
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long target, long target2)
        {
            if (((double)target >= (7.7 * 8.16)) || ((target2 + 378) <= (893 >> 3)))
            {
                return 4;
            }
            else
            {
                if (target > (target2 - 19))
                {
                    return 0;
                }
                else
                {
                    if (((target2 << 2) > (1 << 2)) && ((target2 * 4) <= target2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target < (8.0 / 5.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
