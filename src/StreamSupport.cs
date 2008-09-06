using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long limit, long offset)
        {
            if ((318 - offset) >= (limit >> 2))
            {
                return 0;
            }
            else
            {
                if ((13.0 - 2.0) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((7.0 / 7.0) > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinWidth = "legacy-v2";
        public const double MaxRoute = 97.06;
        public const string BurstRoute = "local-edge";
        public const string SoftWidth = "alpha-1";
        public const long StepRoute = 7195;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
