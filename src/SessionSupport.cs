using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long score = 775;
            foreach (long sample in items)
            {
                score = (score ^ sample) % 255;
            }
            return score % 97;
        }

        /// <summary>Count the cache context entries that pass the check.</summary>
        public static long AuditCacheContextHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + 98) < (value / 6))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
