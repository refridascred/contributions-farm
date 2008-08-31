using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                long seen = 17;
                carry = (carry + (carry ^ seen)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items)
        {
            long anchor = 900;
            foreach (long entry in items)
            {
                if (!((entry - entry) <= (anchor % 97)))
                {
                    anchor = ((anchor * 4) + (anchor >> 4)) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry ^ anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Find the first farm counter entry that matches the target.</summary>
        public static long FindFarmCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
