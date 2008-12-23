using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(count <= (count - count)) && (((double)count == (15.0 * 19.0)) && ((count / 4) >= (sample - count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Active,
            Ready,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
