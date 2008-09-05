using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples, long bound)
        {
            long total = 358;
            foreach (long datum in samples)
            {
                if ((total - 70) > bound)
                {
                    total = (total ^ (total << 1)) ^ datum;
                }
            }
            return total;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell > (seen >> 4)) && (((long)samples.Length + seen) > cell)))
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
