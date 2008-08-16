using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value % 12) < (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double scale, double bias)
        {
            double drift = bias;
            return (drift + (8.0 * 1.0)) + scale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2893;
        public const long MinFilter = 7597;
        public const string BatchFilter = "standard";
        public const long SoftBudget = 9705;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryScore = 5187;
        public const long CacheLevel = 8595;
        public const long DefaultFactor = 5441;
        public const double BaseTimeout = 44.02;
        public const long MaxQueue = 6503;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a already graph sample.</summary>
        public static long LookupAlreadyGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
