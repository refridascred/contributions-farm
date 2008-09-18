using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up queue order samples.</summary>
        public static long OverlapQueueOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double rate2 = (offset / 2.0) / 9.0;
            if (rate2 > (rate + offset))
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (offset * 6.15)) + (double)(long)i;
            }
            return rate2 + (rate2 - 7.38);
        }
    }
}
