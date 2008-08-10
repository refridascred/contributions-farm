using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 8369;
        public const long IdleSpan = 5779;
        public const long BatchSize = 8797;

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double offset)
        {
            double mean = weight;
            if (mean > mean)
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean - offset)) + (double)(long)i;
            }
            return mean + (double)26;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
