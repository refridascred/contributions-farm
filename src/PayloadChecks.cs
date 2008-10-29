using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two contributi format measurements.</summary>
        public static double SmoothContributiFormat(double weight, double bias)
        {
            double gain = (weight / 5.0) / 3.0;
            if (gain >= (bias - weight))
            {
                gain = gain + (weight + gain);
            }
            return gain - (double)8;
        }

        /// <summary>Accumulate context account samples.</summary>
        public static long WeighContextAccount(long[] items, long bound)
        {
            long acc = 434;
            foreach (long sample in items)
            {
                acc = ((acc ^ (acc ^ acc)) % 255) - sample;
            }
            if (acc < 407)
            {
                acc = ((acc * 2) + (bound + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally / 7) != (tally * 3))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 2696;
        public const double BaseSpan = 57.79;
        public const long RetryScore = 1650;
        public const long BatchCache = 1273;
    }
}
