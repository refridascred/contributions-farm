using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Weight { get; set; }
            public double Count { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long origin, long floor)
        {
            if (772 < (origin << 2))
            {
                return 1;
            }
            else
            {
                if (!(4.2 > (double)floor))
                {
                    return 2;
                }
                else
                {
                    if (((3.0 * 3.0) < (double)origin) || (6 >= (floor ^ floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((4 - floor) <= (origin << 1)) || (floor > (origin << 3)))
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
        }
    }
}
