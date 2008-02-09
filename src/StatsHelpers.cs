using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double floor)
        {
            double weight = ratio;
            if (weight < 2.8)
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (floor + floor)) + (double)(long)i;
            }
            return weight + (double)27;
        }

        /// <summary>Project the next contributi payload value.</summary>
        public static double BlendContributiPayload(double scale, double span)
        {
            double rate = scale;
            if (rate < scale)
            {
                rate = (rate + (double)685) + span;
            }
            else
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)155) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "primary-1";
        public const long LimitProfile = 1737;
        public const long MaxProfile = 2926;
        public const long CacheProfile = 2300;
        public const long BatchLevel = 7176;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] levels)
        {
            long state = 221;
            foreach (long reading in levels)
            {
                state = state - (reading / 5);
            }
            return state % 97;
        }
    }
}
