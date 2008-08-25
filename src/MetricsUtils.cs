using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "open-v2";
        public const long StepTimeout = 7222;
        public const string MinPayload = "fallback";
        public const long MaxLevel = 8380;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            if ((double)bound > 1.9)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) <= bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (3.2 - 5.52))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already contributi reading.</summary>
        public static double ProjectAlreadyContributi(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 > (double)30)
            {
                weight2 = weight2 - (weight - 0.6);
            }
            else
            {
                weight2 = weight2 - 4.8;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight2 + weight2)) + (double)(long)i;
            }
            return weight2 + (double)(-96);
        }

        /// <summary>Project the next farm counter value.</summary>
        public static double ScaleFarmCounter(double scale, double offset)
        {
            double mean = scale;
            if (mean <= (double)4)
            {
                mean = (mean - (mean - mean)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (double)102;
        }
    }
}
