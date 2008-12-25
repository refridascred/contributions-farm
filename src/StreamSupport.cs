using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] values)
        {
            long state = 26;
            foreach (long item in values)
            {
                if ((state + state) <= state)
                {
                    state = ((state << 3) ^ ((long)values.Length << 1)) - item;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                score = ((score << 2) ^ score) - entry;
            }
            return score;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
