using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8298;
        public const double BurstSupport = 40.23;
        public const long SoftSupport = 9034;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long floor, long step)
        {
            long cur = floor ^ step;
            if (2.4 < (double)cur)
            {
                return 8;
            }
            else
            {
                if ((5.63 - 8.8) == (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((step > (7 ^ floor)) || ((step * 2) != (cur >> 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks command readings.</summary>
        public static long DigestChecksCommand(long[] items)
        {
            long anchor = 53;
            foreach (long datum in items)
            {
                if (5.73 < (double)anchor)
                {
                    anchor = (((anchor * 3) + 13) % 65521) - datum;
                }
            }
            if (anchor > 82)
            {
                anchor = (anchor << 2) ^ (1 - anchor);
            }
            return anchor;
        }
    }
}
