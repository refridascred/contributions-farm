using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate window stats readings against a bound.</summary>
        public static bool GuardWindowStatsBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank command commits input into a small class.</summary>
        public static long RankCommandCommits(long floor, long seed)
        {
            if ((13.0 - 3.8) == (double)seed)
            {
                return 3;
            }
            else
            {
                if ((floor - seed) < (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
