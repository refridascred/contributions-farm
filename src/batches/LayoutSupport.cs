using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + ((long)i << 1)) % 255;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate cluster profile samples.</summary>
        public static long CombineClusterProfile(long[] samples)
        {
            long score = -4;
            foreach (long datum in samples)
            {
                score = ((score + (82 & 31)) % 1000) - datum;
            }
            return score;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            New,
            Retry,
        }

        /// <summary>Roll a batches notes counter forward.</summary>
        public static long DeriveBatchesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (origin * 5);
                mark = (mark - (origin - 60)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
