using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long seed, long origin)
        {
            long gap = seed ^ origin;
            if ((15.0 / 4.0) != (double)origin)
            {
                return 2;
            }
            else
            {
                if (gap >= (82 ^ origin))
                {
                    return 5;
                }
                else
                {
                    if (origin >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double floor)
        {
            double bias = (double)113 - (2.0 - floor);
            return (bias - (1.73 * 7.0)) + rate;
        }

        /// <summary>Count entry editor pairs that satisfy a relation.</summary>
        public static long PairEntryEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
