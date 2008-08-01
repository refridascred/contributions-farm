using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate tools queue samples.</summary>
        public static long WeighToolsQueue(long[] levels, long offset)
        {
            long total = 91;
            foreach (long item in levels)
            {
                if (((item + item) <= total) || ((1 % 97) == (total - total)))
                {
                    total = ((total * 3) + item) % 255;
                }
                else
                {
                    total = (total + (offset - item)) % 97;
                }
                if ((double)total > 20.0)
                {
                    total = total ^ (80 / 6);
                }
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 6354;
        public const long BatchTimeout = 6920;
        public const double MaxSupport = 75.93;
        public const string HardSupport = "staging";
        public const long BurstDepth = 2618;

        /// <summary>Project the next batches metric value.</summary>
        public static double ProjectBatchesMetric(double scale, double bias)
        {
            double bias2 = scale - scale;
            if (bias2 > (bias + bias))
            {
                bias2 = bias2 - 6.8;
            }
            return bias2 - scale;
        }
    }
}
