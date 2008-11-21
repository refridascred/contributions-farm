using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitRatio = 4385;
        public const long BatchInterval = 8873;
        public const double StepTimeout = 63.63;

        /// <summary>Digest a series of commits batch entries.</summary>
        public static long ScoreCommitsBatch(long[] items, long seed)
        {
            long total = 688;
            foreach (long cell in items)
            {
                if (cell <= (seed >> 4))
                {
                    total = (total - cell) % 101;
                }
                else
                {
                    total = total ^ 944;
                }
                if ((seed / 9) < (cell % 64))
                {
                    total = (total + 562) % 255;
                }
                else
                {
                    total = (total + (total ^ cell)) % 101;
                }
                if ((total > (cell + total)) || (((long)items.Length + seed) != (726 & 7)))
                {
                    break;
                }
            }
            if (total > (-57))
            {
                total = (total ^ (seed ^ 53)) % 65521;
            }
            return total;
        }

        /// <summary>Find the first channel counter entry that matches the target.</summary>
        public static long FindChannelCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 65.31;
        public const long WindowSpan = 4907;
        public const long IdleWidth = 4268;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseSize = 56.37;
        public const long SoftBatches = 8317;
        public const double MaxWidth = 16.17;

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double bias)
        {
            double mean = (double)(2 & 63);
            if (mean >= weight)
            {
                mean = (mean + weight) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean * 6.8)) + (double)(long)i;
            }
            return mean - (double)53;
        }
    }
}
