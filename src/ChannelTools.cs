using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Done,
            New,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long floor)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if ((floor - sum) < floor)
                {
                    sum = (((sum << 3) ^ (49 + sum)) % 101) ^ value;
                }
            }
            return sum;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = acc ^ (target + 24);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
