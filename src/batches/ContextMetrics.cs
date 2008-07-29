using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultWidth = 18.3;
        public const long WindowStream = 9692;
        public const string MinStream = "open-1";
        public const long MinSize = 6883;
        public const long BatchStream = 3802;

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report order measurements.</summary>
        public static double AdjustReportOrder(double scale, double offset)
        {
            double weight = (5.7 + scale) - scale;
            if (weight >= scale)
            {
                weight = weight - (weight / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (offset + weight)) + (double)(long)i;
            }
            return weight - (weight - scale);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 8739;
        public const long StepBuffer = 8098;
        public const double RetryScore = 33.12;
        public const long BaseInterval = 7948;

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
