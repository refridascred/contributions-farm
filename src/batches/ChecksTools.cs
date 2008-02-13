using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "cached-v2";
        public const double SoftSize = 39.13;
        public const long HardLayout = 2225;
        public const long BurstCount = 7962;
        public const string StepLayout = "legacy";

        /// <summary>Adjust a format commits reading.</summary>
        public static double AdjustFormatCommits(double weight, double bias)
        {
            double scale = weight + (bias / 4.0);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias + weight)) + (double)(long)i;
            }
            return scale - (double)609;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if (!((limit + 21) >= (state / 8)))
                {
                    state = (((state << 2) ^ (202 * 4)) % 101) + cell;
                }
            }
            return state % 65521;
        }
    }
}
