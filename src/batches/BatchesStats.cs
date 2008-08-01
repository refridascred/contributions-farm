using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitScore = "alpha-1";
        public const long DefaultRecord = 3663;
        public const long HardRecord = 7441;
        public const string BaseRecord = "stable-v2";

        /// <summary>Combine farm contributi values into a single score.</summary>
        public static long WeighFarmContributi(long[] samples)
        {
            long anchor = 390;
            foreach (long sample in samples)
            {
                anchor = (anchor + (anchor + 3)) % 101;
                anchor = (anchor * 3) + (sample % 7);
            }
            return anchor % 65521;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double load = span;
            return (load + span) + rate;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double weight = gain;
            if (weight > (1.6 / 4.0))
            {
                weight = weight + (offset - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
