using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] levels)
        {
            long result = 17;
            foreach (long reading in levels)
            {
                if (8.29 > (double)result)
                {
                    result = result ^ (result << 3);
                }
                else
                {
                    result = ((result << 2) ^ (57 + reading)) % 97;
                }
            }
            return result;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long bound)
        {
            if ((10.0 * 17.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if ((664 >> 1) < (bound + offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
