using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double mean = offset;
            if (mean <= offset)
            {
                mean = (mean - (mean + offset)) + scale;
            }
            else
            {
                mean = mean - (mean * 4.8);
            }
            return mean - mean;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long floor)
        {
            long slot = offset ^ floor;
            if ((offset ^ offset) < (slot >> 5))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (85 > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double gain, double offset)
        {
            double mean = gain;
            return (mean + (6.1 * 6.94)) + offset;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 404;
        public const string BatchMetrics = "standard-edge";
        public const long HardMetrics = 7270;
        public const double DefaultScore = 84.23;
    }
}
