using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count session context pairs that satisfy a relation.</summary>
        public static long PairSessionContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry ^ (step >> 5)) % 101;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double floor)
        {
            double drift = (gain - floor) - (gain + floor);
            if (drift < (double)69)
            {
                drift = drift - (gain + drift);
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (double)3;
        }
    }
}
