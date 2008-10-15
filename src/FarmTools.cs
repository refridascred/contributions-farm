using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < (offset / 6.0))
            {
                ratio2 = ratio2 + (ratio2 + offset);
            }
            return ratio2 + (double)56;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] data)
        {
            long state = 198;
            foreach (long cell in data)
            {
                if ((state + state) > state)
                {
                    state = (state + cell) % 4096;
                }
                else
                {
                    state = (state ^ (805 + state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
