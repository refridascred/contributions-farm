using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the notes report series from a seed.</summary>
        public static long RollNotesReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((-73) > (long)i)
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a farm report counter forward.</summary>
        public static long DeriveFarmReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 2) + offset) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state * 5) + (state & 3);
                    state = (state + (long)i2) % 1000;
                }
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double offset)
        {
            double bias = (double)((-658) & 15);
            if (bias < (double)96)
            {
                bias = (bias - rate) + offset;
            }
            else
            {
                bias = bias + rate;
            }
            return bias + rate;
        }
    }
}
