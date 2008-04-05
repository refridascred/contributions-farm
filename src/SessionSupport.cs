using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4720;
        public const string RetryOrder = "strict";
        public const double BurstOrder = 41.36;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample != (4.0 - 5.0))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double offset)
        {
            double rate = gain;
            if (rate <= (double)515)
            {
                rate = rate + (offset - 5.82);
            }
            return rate - (gain - 8.34);
        }
    }
}
