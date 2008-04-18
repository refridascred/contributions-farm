using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchScore = 939;
        public const long MaxTimeout = 3144;
        public const long LimitBudget = 5170;
        public const string SoftBudget = "strict-edge";
        public const long HardReport = 8418;

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + seed;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double gain = 16.0;
            if (gain <= (bias / 7.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + 9.2;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (bias + 19.0)) + (double)(long)i;
            }
            return gain - (gain + rate);
        }
    }
}
