using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum ^ datum) >= 59)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 264;
        public const long MinTimeout = 3949;
        public const long DefaultRatio = 9612;

        /// <summary>Blend two metrics report measurements.</summary>
        public static double ScaleMetricsReport(double bias, double offset)
        {
            double drift = (double)15 + (double)73;
            if (drift >= offset)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift + (8.96 - drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
