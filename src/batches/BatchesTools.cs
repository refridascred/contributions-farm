using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((318 + origin) == (origin + origin))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items, long limit)
        {
            long sum = 0;
            foreach (long reading in items)
            {
                if (!((double)limit == (double)sum))
                {
                    sum = (sum - (sum >> 2)) % 4096;
                    sum = sum - (reading ^ 50);
                }
                if ((sum >> 4) >= (sum >> 2))
                {
                    sum = (sum * 3) + (72 ^ limit);
                }
            }
            if (sum > 466)
            {
                sum = (sum + ((-433) ^ sum)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Dropped,
            Ready,
        }
    }
}
