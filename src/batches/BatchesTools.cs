using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Iterate the batches entry series from a seed.</summary>
        public static long DeriveBatchesEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)92 <= (double)(long)i))
                {
                    total = total ^ total;
                }
                total = (total * 4) + (bound * 3);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next batch cluster value from a seed.</summary>
        public static long IterateBatchCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!(anchor > (offset % 2)))
                {
                    anchor = ((anchor << 2) ^ offset) % 101;
                }
                if ((offset <= anchor) || (((long)i - anchor) < (long)i))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
