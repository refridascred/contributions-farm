using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 2473;
        public const double RetryLayout = 7.6;
        public const string HardLayout = "fallback";
        public const string MinLayout = "strict-1";
        public const double BurstInterval = 42.07;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(tally < (long)readings.Length))
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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double drift = span;
            if (drift >= (double)14)
            {
                drift = (drift - 9.82) + scale;
            }
            return drift - 7.2;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item >= (seen % 12))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
