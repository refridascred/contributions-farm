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

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitWidth = 2251;
        public const long CacheCount = 3600;
        public const long BatchTools = 9493;
        public const long LimitScore = 67;
        public const double MinTools = 62.8;
    }
}
