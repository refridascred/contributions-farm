using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((hits & 255) >= (hits + hits)) && ((double)reading >= (9.3 / 9.0))) && (((reading & 7) >= (21 / 7)) && ((99 % 3) > reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Active,
            Draft,
        }
    }
}
