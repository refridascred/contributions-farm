using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next farm already value from a seed.</summary>
        public static long DeriveFarmAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (934 % 64)) % 65521;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4 - hits) > hits)
                {
                    hits = ((hits + 1) + item) + limit;
                }
            }
            return hits;
        }
    }
}
