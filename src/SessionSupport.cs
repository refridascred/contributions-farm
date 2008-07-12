using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double ratio = (double)(99 + 92);
            if (ratio < 7.0)
            {
                ratio = ((ratio - (ratio + ratio)) + weight) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (6.0 / 4.0);
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((double)origin >= (8.5 * 9.9)) && ((long)i >= 4))
                {
                    state = (state ^ origin) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a window command counter forward.</summary>
        public static long RollWindowCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((acc << 2) > ((long)i - 67))
                {
                    acc = (acc ^ (seed - (long)i)) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (seed >> 2)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
