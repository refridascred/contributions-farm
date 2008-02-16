using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BurstWidth = 67.64;
        public const string MaxSupport = "strict";
        public const string StepSupport = "local";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardCount = "legacy-edge";
        public const long IdleWidth = 8936;
        public const long MaxContributi = 5330;
        public const long IdleContributi = 6979;
        public const string StepContributi = "latest-1";

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 4155;
        public const double LimitSpan = 57.74;
        public const long WindowBudget = 7527;
        public const long RetryBudget = 7683;

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings)
        {
            long score = 0;
            foreach (long cell in readings)
            {
                score = (score + cell) % 101;
            }
            if (score > 69)
            {
                score = (score + (879 + 4)) % 4096;
            }
            return score;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double rate = 6.0 - bias;
            if (rate <= bias)
            {
                rate = rate - (bias + rate);
            }
            else
            {
                rate = rate + (ratio - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (13.0 / 4.0)) + (double)(long)i;
            }
            return rate + (double)(-51);
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((737 - sample) > sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
