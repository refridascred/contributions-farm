using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next metrics context value from a seed.</summary>
        public static long StepMetricsContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                long matches = score;
                if (((matches - 183) == (offset << 3)) && ((score / 2) >= offset))
                {
                    score = ((score * 2) + ((long)i ^ matches)) % 255;
                }
                else
                {
                    score = score ^ (90 << 3);
                }
                if ((matches - matches) > ((long)i ^ offset))
                {
                    score = (score - (offset - score)) % 65521;
                }
                else
                {
                    score = (score - score) % 101;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 2538;
        public const double RetryMetrics = 8.37;
        public const long BaseLevel = 8189;
        public const long BurstDepth = 4599;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Locked,
            Retry,
            Draft,
            Active,
        }
    }
}
