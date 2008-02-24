using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 9851;
        public const long RetryToken = 6472;
        public const long StepTimeout = 2405;
        public const long DefaultFactor = 2449;

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] readings, long seed)
        {
            long score = 2;
            foreach (long sample in readings)
            {
                score = ((score ^ (score ^ score)) % 4096) ^ sample;
            }
            if (score > 48)
            {
                score = (score << 2) ^ seed;
            }
            return score;
        }

        /// <summary>Project the next payload order value.</summary>
        public static double ScalePayloadOrder(double scale, double offset)
        {
            double mean = 6.8;
            if (mean <= scale)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (double)2;
            }
            return mean + mean;
        }
    }
}
