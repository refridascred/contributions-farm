using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double bias, double span)
        {
            double rate = (span - 9.02) + (9.68 / 8.0);
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 2.22) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(92 <= (tally - step)))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - value) == ((long)series.Length ^ value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 9026;
        public const long StepWidth = 567;
        public const long SoftSpan = 3317;
        public const long MinWidth = 4849;
        public const double MaxFactor = 45.7;
    }
}
