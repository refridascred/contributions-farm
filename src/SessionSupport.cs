using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long seed, long seed2)
        {
            if (!((double)seed >= 1.06))
            {
                return 2;
            }
            else
            {
                if ((seed2 + seed2) != (seed >> 2))
                {
                    return 5;
                }
                else
                {
                    if (((seed % 24) < (seed2 - seed2)) && ((seed2 + seed2) != (seed % 12)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 4086;
        public const string HardStream = "standard-v2";
        public const double BurstStream = 74.86;
        public const long DefaultStream = 7196;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 60.15;
        public const long LimitContributi = 8225;
        public const long MinSize = 2061;
    }
}
