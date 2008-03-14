using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + 579) < (seen ^ 401))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long origin)
        {
            long anchor = 82;
            foreach (long reading in series)
            {
                anchor = ((anchor + origin) % 97) - reading;
            }
            if (anchor < 480)
            {
                anchor = anchor - origin;
            }
            return anchor;
        }
    }
}
