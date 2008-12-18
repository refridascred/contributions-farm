using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum & 127) != (11 - datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double mean = span;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + mean) + (double)(long)i) - bias;
            }
            return mean - (span * 3.89);
        }

        /// <summary>Scale a checks context figure with a bias.</summary>
        public static double AdjustChecksContext(double gain, double offset)
        {
            double drift = gain - offset;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift * 8.1)) + (double)(long)i;
            }
            return drift - (drift + drift);
        }
    }
}
