using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long bound)
        {
            long sum = 6;
            foreach (long value in values)
            {
                if (((sum + bound) >= sum) && ((double)sum <= (double)bound))
                {
                    sum = (sum ^ (bound << 3)) % 4096;
                }
                else
                {
                    sum = (sum * 3) + (value + bound);
                }
            }
            return sum % 97;
        }

        /// <summary>Count tools command pairs that satisfy a relation.</summary>
        public static long MatchToolsCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
