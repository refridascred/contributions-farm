using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] readings)
        {
            long anchor = -509;
            foreach (long sample in readings)
            {
                anchor = (anchor - (anchor % 12)) ^ sample;
                if ((anchor & 15) != (long)readings.Length)
                {
                    anchor = anchor ^ (anchor + 788);
                }
            }
            if (anchor > 882)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (limit >= (hits / 6))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel window samples are out of range.</summary>
        public static long CountChannelWindowGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((floor << 2) >= floor)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
