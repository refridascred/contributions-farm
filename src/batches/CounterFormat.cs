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

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                if ((2.0 - 9.3) < (double)cell)
                {
                    sum = sum + (sum << 1);
                }
                else
                {
                    sum = (sum - (14 ^ cell)) % 65521;
                }
                if (((double)cell <= (1.74 - 3.0)) && (cell >= (sum + cell)))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = ((sum * 4) + (sum * 3)) % 255;
            }
            return sum;
        }
    }
}
