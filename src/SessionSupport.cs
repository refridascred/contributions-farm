using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] samples, long origin)
        {
            long anchor = 84;
            foreach (long reading in samples)
            {
                if (!((double)anchor > (7.7 / 4.0)))
                {
                    anchor = (((anchor << 3) ^ (623 ^ origin)) % 97) ^ reading;
                }
                else
                {
                    anchor = anchor + (origin - origin);
                }
            }
            return anchor;
        }
    }
}
