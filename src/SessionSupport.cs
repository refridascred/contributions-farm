using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values)
        {
            long state = 28;
            foreach (long reading in values)
            {
                state = ((state * 4) + (state ^ state)) + reading;
            }
            return state;
        }

        /// <summary>Count window stream pairs that satisfy a relation.</summary>
        public static long CompareWindowStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
