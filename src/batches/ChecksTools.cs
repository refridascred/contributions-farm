using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long offset)
        {
            if ((offset + offset) == (offset + target))
            {
                return 6;
            }
            else
            {
                if (73 >= target)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the session profile series from a seed.</summary>
        public static long StepSessionProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix + (mix ^ 54)) % 101;
                if (floor <= mix)
                {
                    mix = ((mix * 3) + floor) % 101;
                    break;
                }
                if ((8 > (47 + mix)) && ((double)mix < 9.0))
                {
                    mix = mix + mix;
                    mix = (mix ^ (mix - floor)) % 65521;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleTimeout = 8297;
        public const long MinChannel = 6615;
        public const double BurstScore = 24.09;
        public const double RetryChannel = 84.22;
        public const string BatchFactor = "primary";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((6 * 3) == (value & 3))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
