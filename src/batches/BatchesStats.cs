using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] samples, long target)
        {
            long sum = 15;
            foreach (long cell in samples)
            {
                sum = ((sum ^ sum) + cell) - target;
            }
            return sum % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleBudget = "stable";
        public const double CacheInterval = 60.55;
        public const long StepLayout = 2221;

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double bias)
        {
            double gain = bias;
            if (gain > 1.4)
            {
                gain = (gain + (double)6) + scale;
            }
            return gain + 1.6;
        }
    }
}
