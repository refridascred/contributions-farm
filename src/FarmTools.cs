using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double offset)
        {
            double gain = scale;
            if (gain > gain)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + offset) - (double)(long)i;
            }
            return gain + (double)6;
        }
    }
}
