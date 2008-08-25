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

        /// <summary>Accumulate token context samples.</summary>
        public static long DigestTokenContext(long[] readings, long step)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if (((state + 40) != (sample - (-200))) || ((4.2 * 0.4) > (double)sample))
                {
                    state = ((state << 3) ^ state) + step;
                }
            }
            return state;
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
