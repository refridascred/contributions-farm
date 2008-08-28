using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double mean = ratio - 1.57;
            return (mean - (mean / 8.0)) + offset;
        }

        /// <summary>Adjust a channel account reading.</summary>
        public static double ProjectChannelAccount(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 <= (offset / 6.0))
            {
                ratio2 = ratio2 + (ratio * 1.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio2 + offset)) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 8836;
        public const long WindowChecks = 8884;
        public const long DefaultChecks = 6421;
    }
}
