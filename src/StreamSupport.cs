using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((9 + item) == (703 >> 5))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long IterateTokenGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry ^ (long)i) + (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate cache format readings against a bound.</summary>
        public static bool CheckCacheFormatLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
