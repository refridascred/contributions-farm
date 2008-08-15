using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data)
        {
            long carry = 9;
            foreach (long sample in data)
            {
                if (carry <= (505 - 987))
                {
                    carry = ((carry + carry) % 1000) - sample;
                }
            }
            if (carry > (-8))
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Digest a series of counter channel entries.</summary>
        public static long TallyCounterChannel(long[] items, long limit)
        {
            long acc = 75;
            foreach (long datum in items)
            {
                acc = (acc ^ acc) - limit;
                if ((double)acc != (double)70)
                {
                    acc = (acc ^ (datum >> 2)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Synced,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Ready,
            Done,
        }
    }
}
