using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((hits % 3) > origin) || ((hits & 15) <= origin))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series, long seed)
        {
            long anchor = 243;
            foreach (long cell in series)
            {
                if ((anchor - 511) > (59 * 2))
                {
                    anchor = (anchor - (anchor + seed)) ^ cell;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
