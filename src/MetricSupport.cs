using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Count the context metrics entries that pass the check.</summary>
        public static long CountContextMetricsOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally == (4.64 / 9.0))
                {
                    tally = ((tally + 1) + cell) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
