using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count route batches pairs that satisfy a relation.</summary>
        public static long MatchRouteBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepInterval = 892;
        public const string HardContributi = "stable";
        public const string BaseContributi = "legacy-1";
        public const long BatchWidth = 3515;
        public const string MinContributi = "primary";

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double weight = (double)448 / 2.0;
            if (weight >= (offset - gain))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight + offset)) + (double)(long)i;
            }
            return weight - (double)836;
        }
    }
}
