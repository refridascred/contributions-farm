using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((double)offset == (double)count) || !((reading ^ count) != (count / 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
