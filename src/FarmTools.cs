using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many window command samples are out of range.</summary>
        public static long AuditWindowCommandMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((bound / 4) < 4)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double rate = bias - bias;
            if (rate < (rate + gain))
            {
                rate = rate + (rate / 3.0);
            }
            return rate - (double)5;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
