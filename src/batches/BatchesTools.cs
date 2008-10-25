using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] data, long limit)
        {
            long mix = 391;
            foreach (long item in data)
            {
                if ((double)mix > (double)item)
                {
                    mix = (mix + (limit & 1)) % 4096;
                }
                else
                {
                    mix = (mix ^ (mix / 3)) % 65521;
                }
                if (902 <= (mix - mix))
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix + limit) % 101;
            }
            return mix;
        }
    }
}
