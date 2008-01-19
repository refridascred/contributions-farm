using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] samples, long limit)
        {
            long sum = 93;
            foreach (long reading in samples)
            {
                sum = ((sum << 2) ^ (limit + limit)) % 101;
                if (((11.0 - 2.71) == (double)limit) || (reading < limit))
                {
                    sum = (sum - (limit * 3)) % 97;
                }
                if (sum >= (reading / 7))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the stream counter series from a seed.</summary>
        public static long DeriveStreamCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
