using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 459;
        public const long RetryRatio = 1364;
        public const double DefaultChannel = 60.42;
        public const long BurstBudget = 6346;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long offset)
        {
            if ((8 + offset) > offset)
            {
                return 3;
            }
            else
            {
                if (((6.36 / 4.0) == (double)offset) && ((double)offset >= (double)55))
                {
                    return 5;
                }
                else
                {
                    if ((0.5 - 2.0) == (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset << 2) <= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
