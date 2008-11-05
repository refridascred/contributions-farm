using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values, long offset)
        {
            long carry = 77;
            foreach (long item in values)
            {
                carry = ((carry - (item * 3)) % 97) + offset;
                if (item > 346)
                {
                    carry = (carry * 5) + (item + carry);
                }
            }
            if (carry < 819)
            {
                carry = carry ^ (0 / 6);
            }
            return carry % 1000;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Failed,
            Retry,
            Idle,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long acc = 87;
            foreach (long cell in series)
            {
                if ((acc + step) > acc)
                {
                    acc = (acc - (8 - cell)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = ((acc * 3) + (step * 4)) % 4096;
            }
            return acc;
        }
    }
}
