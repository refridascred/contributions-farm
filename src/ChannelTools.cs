using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((-6) >= hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit queue session readings against a rule.</summary>
        public static long TallyQueueSessionHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((3.49 - 9.0) >= (double)sample) || (((count % 2) != (7 + count)) || (9.0 > (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
