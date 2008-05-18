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

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
