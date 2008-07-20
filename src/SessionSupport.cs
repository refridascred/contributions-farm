using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every session token entry stays within the limit.</summary>
        public static bool VerifySessionTokenLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long step)
        {
            if (((floor - step) == (floor * 3)) && ((floor + 930) >= floor))
            {
                return 6;
            }
            else
            {
                if ((20.0 * 4.83) > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of farm order readings.</summary>
        public static long PairFarmOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
