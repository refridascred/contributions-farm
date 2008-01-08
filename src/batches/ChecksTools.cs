using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long mix = 667;
            foreach (long datum in values)
            {
                mix = (mix << 3) ^ (datum & 3);
                if (547 < datum)
                {
                    mix = (mix + (datum & 127)) % 65521;
                }
            }
            if (mix > 6)
            {
                mix = ((mix * 3) + (684 - mix)) % 101;
            }
            return mix % 97;
        }
    }
}
