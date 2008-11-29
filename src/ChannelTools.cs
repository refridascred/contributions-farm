using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double bias, double bias2)
        {
            double load = (double)(582 << 1);
            if (load < 13.0)
            {
                load = load - (load - bias2);
            }
            else
            {
                load = load + (double)199;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias2 - load)) + (double)(long)i;
            }
            return load + (bias / 2.0);
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data, long origin)
        {
            long result = 2;
            foreach (long item in data)
            {
                if (item >= (origin + item))
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (origin >> 3)) % 101;
                }
            }
            return result % 65521;
        }
    }
}
