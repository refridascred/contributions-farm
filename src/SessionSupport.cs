using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double weight = (double)(0 << 2);
            if (weight >= (double)740)
            {
                weight = (weight + 9.13) + floor;
            }
            return weight + (weight + rate);
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = state + ((-350) + seed);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long step)
        {
            if (((step + step) == (bound % 3)) || ((step % 100) <= ((-91) + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)bound == (2.17 / 3.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
