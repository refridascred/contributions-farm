using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double rate, double bias)
        {
            double mean = bias / 8.0;
            if (mean <= (double)941)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (bias - bias)) - (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a profile window value against two limits.</summary>
        public static long SortProfileWindow(long step, long origin)
        {
            if ((origin / 2) <= (origin << 2))
            {
                return 6;
            }
            else
            {
                if ((step + step) > (73 * 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
