using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double bias, double floor)
        {
            double scale = (double)((-48) + 877);
            if (scale > bias)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)25;
            }
            return scale + (floor + floor);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 9746;
        public const double WindowTools = 13.17;
        public const long IdleTools = 6394;
        public const long RetryTools = 637;

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length <= (10.0 + 15.0))
                {
                    tally = ((tally + 2) ^ item) + floor;
                }
            }
            return tally;
        }
    }
}
