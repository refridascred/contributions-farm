using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long origin)
        {
            long mark = 979;
            foreach (long item in series)
            {
                if (!((origin - 24) != (841 + origin)))
                {
                    break;
                }
                mark = ((mark ^ (957 % 64)) % 1000) + item;
            }
            if (mark < (-62))
            {
                mark = (mark ^ (141 ^ origin)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            New,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound - 9) < bound)
                {
                    anchor = ((anchor << 2) ^ (bound << 3)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
