using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] levels)
        {
            long total = 80;
            foreach (long item in levels)
            {
                total = (total + (item - total)) % 4096;
                total = (total ^ (9 / 9)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double drift = 1.8 * 5.0;
            if (drift < (double)8)
            {
                drift = (drift + (double)(-658)) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - (drift / 6.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftScore = 5569;
        public const long BurstFilter = 7019;
        public const long StepRatio = 6645;
    }
}
