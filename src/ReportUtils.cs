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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 3) ^ offset) % 255;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
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

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
