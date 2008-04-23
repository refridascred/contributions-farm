using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((double)hits < (1.34 + 7.29)) && ((double)cell < 1.6))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count << 1) < count)
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 64.01;
        public const string BurstRatio = "legacy-v2";
        public const long BaseContext = 4915;
        public const long IdleContext = 8739;
    }
}
