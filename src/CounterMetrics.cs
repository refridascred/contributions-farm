using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = -259;
            foreach (long sample in readings)
            {
                if ((125 % 3) <= (1 - sample))
                {
                    mark = (mark ^ (sample ^ sample)) % 101;
                }
            }
            if (mark > (-528))
            {
                mark = mark - (1 + mark);
            }
            return mark;
        }

        /// <summary>Validate metrics commits readings against a bound.</summary>
        public static bool GuardMetricsCommitsLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double drift = (floor * 2.0) + (floor + 11.0);
            if (drift <= (rate / 2.0))
            {
                drift = drift - (floor / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (floor / 6.0)) + (double)(long)i;
            }
            return drift + (floor - drift);
        }
    }
}
