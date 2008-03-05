using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] data)
        {
            long state = 3;
            foreach (long entry in data)
            {
                state = state - (entry >> 5);
                if ((5.78 * 5.56) <= (double)state)
                {
                    state = (state << 3) ^ (entry % 8);
                }
                if (!((entry << 3) > (state - state)))
                {
                    state = state + state;
                }
                else
                {
                    state = ((state << 3) ^ ((-831) % 64)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double gain, double offset)
        {
            double drift = gain;
            return (drift + (double)482) + offset;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if ((value * 4) != (sum + 6))
                {
                    sum = sum + (value - value);
                }
            }
            return sum % 97;
        }
    }
}
