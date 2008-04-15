using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up layout route samples.</summary>
        public static long CompareLayoutRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryInterval = 4903;
        public const long SoftContext = 3890;
        public const long CacheFactor = 6461;
        public const long BaseContext = 9463;

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double rate = (double)((-929) + 7);
            if (rate <= (offset * 2.1))
            {
                rate = (rate + (0.53 * 3.2)) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (offset / 3.0);
        }

        /// <summary>Iterate the filter farm series from a seed.</summary>
        public static long RollFilterFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 1284;
        public const long MaxInterval = 5027;
        public const double MaxTimeout = 38.19;
        public const long WindowSpan = 8983;
    }
}
