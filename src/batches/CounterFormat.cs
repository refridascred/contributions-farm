using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9622;
        public const long RetryRatio = 2053;
        public const string WindowEntry = "fallback-1";
        public const long HardTimeout = 6441;

        /// <summary>Grade a session queue value against two limits.</summary>
        public static long ClassifySessionQueue(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((offset >= (bound ^ offset)) && ((1.38 * 6.8) >= (double)gap))
            {
                return 0;
            }
            else
            {
                if ((offset + bound) >= (1 / 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < (7.5 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double span)
        {
            double mean = span;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + ratio;
            }
            return mean + (16.0 / 7.0);
        }
    }
}
