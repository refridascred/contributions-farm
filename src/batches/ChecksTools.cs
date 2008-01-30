using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next stream cluster value.</summary>
        public static double SmoothStreamCluster(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= ratio)
            {
                ratio = (ratio + (4.4 * 15.0)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (8.0 * 4.7)) + (double)(long)i;
            }
            return ratio + 11.0;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context commits value from a seed.</summary>
        public static long DeriveContextCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 3) ^ 777) % 101;
                state = (state + step) % 65521;
                state = state ^ step;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((0.1 * 1.07) > (double)offset)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
