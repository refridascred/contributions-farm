using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstTimeout = 1837;
        public const long DefaultDepth = 208;
        public const string SoftCount = "legacy";
        public const string DefaultCount = "open-v2";

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double ratio = weight + (double)5;
            if (ratio > (weight + weight))
            {
                ratio = ratio - (ratio + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)4) - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed ^ 4) < (seed - seed))
                {
                    mix = (mix - (712 * 5)) % 4096;
                    mix = (mix + (seed & 63)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (26 % 97);
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen > sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Stale,
            Draft,
            Closed,
        }
    }
}
