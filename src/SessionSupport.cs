using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry / 6) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits < 33)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
