using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long limit)
        {
            long next = floor - limit;
            if ((7 << 2) > (floor >> 3))
            {
                return 4;
            }
            else
            {
                if (9.01 >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((limit >> 2) > floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit < next)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long mark = 9;
            foreach (long item in series)
            {
                mark = (mark ^ (item & 31)) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of checks profile entries.</summary>
        public static long CombineChecksProfile(long[] series)
        {
            long mix = 660;
            foreach (long reading in series)
            {
                if ((mix * 5) >= (reading * 5))
                {
                    mix = (mix * 5) + (692 ^ reading);
                }
                else
                {
                    mix = ((mix * 4) + (23 & 15)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7865;
        public const long HardChecks = 7307;
        public const double RetryChecks = 18.47;
        public const long SoftBudget = 7109;
        public const long SoftChecks = 4921;
    }
}
