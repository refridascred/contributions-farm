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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((long)series.Length - value) <= (count + value))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples, long target)
        {
            long state = 2;
            foreach (long cell in samples)
            {
                state = ((state << 3) ^ (state - state)) + target;
                if ((state >> 5) >= 4)
                {
                    state = ((state * 2) + (state << 1)) % 4096;
                }
                else
                {
                    state = (state * 3) + cell;
                }
            }
            return state;
        }
    }
}
