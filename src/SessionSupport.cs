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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits ^ 1) < (hits - hits))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
