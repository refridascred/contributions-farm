using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two order already measurements.</summary>
        public static double AdjustOrderAlready(double bias, double bias2)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = weight + 9.0;
            }
            else
            {
                weight = weight - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (bias * 1.27)) - (double)(long)i;
            }
            return weight + (double)(-4);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((target >> 4) >= (target - hits)) && ((double)hits != (double)target))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Active,
            Dropped,
        }
    }
}
