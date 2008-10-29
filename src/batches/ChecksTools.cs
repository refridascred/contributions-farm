using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = -57;
            foreach (long sample in levels)
            {
                if (332 >= (state % 60))
                {
                    state = ((state * 2) + (sample - (long)levels.Length)) % 97;
                }
            }
            if (state < 2)
            {
                state = ((state << 2) ^ (56 ^ state)) % 65521;
            }
            return state % 1000;
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
