using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((93 + 8) < (datum + tally))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultRatio = 5.24;
        public const string RetryFactor = "primary-1";
        public const long SoftSpan = 7466;
        public const long StepOrder = 9434;

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double rate = (double)(-794) * 17.0;
            if (rate <= (double)390)
            {
                rate = (rate - bias) + bias2;
            }
            return rate + bias;
        }
    }
}
