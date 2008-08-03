using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)limit != (15.0 * 17.0)))
                {
                    mix = ((mix * 5) + (long)i) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 2) + ((long)i / 8)) % 65521;
                state = state + 1;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double rate = 11.0;
            return (rate - gain) + offset;
        }

        /// <summary>Fold a list of order context readings.</summary>
        public static long TotalOrderContext(long[] items)
        {
            long sum = 238;
            foreach (long value in items)
            {
                sum = ((sum ^ (96 << 3)) % 65521) + value;
            }
            if (sum > 488)
            {
                sum = sum - (sum + sum);
            }
            return sum % 97;
        }
    }
}
