using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double ratio = (double)7;
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio + (ratio * 4.0)) + (double)(long)i) + bias) + span;
            }
            return ratio + (ratio / 7.0);
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Closed,
            Stale,
            Queued,
            Paused,
        }
    }
}
