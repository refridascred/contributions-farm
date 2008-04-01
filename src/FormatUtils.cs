using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many report window samples are out of range.</summary>
        public static long MeasureReportWindowHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((60 << 3) <= (sample >> 3)))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine notes counter values into a single score.</summary>
        public static long DigestNotesCounter(long[] readings, long step)
        {
            long acc = 165;
            foreach (long item in readings)
            {
                acc = acc - (step + item);
            }
            if (acc > 43)
            {
                acc = acc ^ (step + step);
            }
            return acc;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowCount = 9089;
        public const long WindowAlready = 1759;
        public const long SoftAlready = 3733;
        public const string SoftInterval = "primary-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 2157;
        public const long BaseEntry = 6529;
        public const double RetryEntry = 86.84;

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double rate = (double)(81 ^ 92);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + (bias2 / 6.0)) + (double)(long)i) + bias;
            }
            return rate - bias2;
        }
    }
}
