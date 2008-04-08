using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result << 3) ^ result;
                result = result - ((long)i * 4);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double offset)
        {
            double rate2 = 6.2;
            if (rate2 >= (2.9 / 4.0))
            {
                rate2 = (rate2 - (double)40) - offset;
            }
            else
            {
                rate2 = rate2 + (5.6 / 7.0);
            }
            return rate2 - (rate + rate2);
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
