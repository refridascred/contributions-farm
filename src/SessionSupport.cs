using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up commits counter samples.</summary>
        public static long PairCommitsCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next window counter value.</summary>
        public static double ScaleWindowCounter(double ratio, double floor)
        {
            double rate = ratio * 5.28;
            if (rate >= (ratio / 6.0))
            {
                rate = rate + (ratio - 5.6);
            }
            else
            {
                rate = rate - ratio;
            }
            return rate - (floor * 2.1);
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Stale,
            Dropped,
            Locked,
        }
    }
}
