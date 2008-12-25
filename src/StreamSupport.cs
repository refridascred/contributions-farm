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

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double rate2 = 0.5 * 0.4;
            if (rate2 >= rate)
            {
                rate2 = rate2 - (double)62;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + span) + (double)(long)i;
            }
            return rate2 - span;
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
