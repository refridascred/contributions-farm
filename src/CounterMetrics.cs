using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long TallyChecksQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally >= (value ^ value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
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
