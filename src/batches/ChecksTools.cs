using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinRatio = 88.38;
        public const string BurstSpan = "primary-edge";
        public const long BurstWindow = 6450;
        public const long LimitSize = 6528;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long carry = 5;
            foreach (long item in series)
            {
                if ((carry + carry) < carry)
                {
                    carry = (carry + 6) ^ item;
                }
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftSpan = 3508;
        public const string WindowWidth = "local-1";
        public const long BatchRecord = 6280;
        public const long BurstFactor = 9756;

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long bound)
        {
            if ((origin >> 1) != (bound / 5))
            {
                return 5;
            }
            else
            {
                if (!((-592) > bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound - origin) <= (bound >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (12 >= (origin >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
