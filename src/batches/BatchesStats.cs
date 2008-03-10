using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                carry = ((carry - ((long)levels.Length + carry)) % 4096) ^ cell;
                if ((double)carry > (1.74 - 1.7))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long floor)
        {
            long lane = offset - floor;
            if ((lane * 4) > lane)
            {
                return 8;
            }
            else
            {
                if ((lane >> 5) < (-9))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Pending,
            Locked,
            Ready,
        }
    }
}
