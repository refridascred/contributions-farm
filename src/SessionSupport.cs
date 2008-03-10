using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxSpan = 9488;
        public const string SoftQueue = "latest-v2";
        public const long SoftRatio = 1456;
        public const string BatchQueue = "primary";

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long seed)
        {
            if ((seed << 3) <= (seed + 64))
            {
                return 2;
            }
            else
            {
                if (((14.0 / 2.0) == (double)seed) || ((floor >> 5) > seed))
                {
                    return 5;
                }
                else
                {
                    if (64 > (floor % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.0 > (double)seed) || ((double)seed > (2.9 - 2.3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double weight, double span)
        {
            double ratio = span;
            if (ratio < (weight - span))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + (weight * 17.0);
        }
    }
}
