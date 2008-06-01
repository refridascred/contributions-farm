using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account payload readings against a rule.</summary>
        public static long AuditAccountPayloadMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((hits & 255) <= (-4)) && ((double)target != (double)hits)) || ((8 <= sample) && ((target - hits) > target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!((long)i <= ((long)i ^ seed)))
                {
                    result = (result << 3) ^ (857 - seed);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
