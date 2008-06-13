using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a counter metrics reading.</summary>
        public static double AdjustCounterMetrics(double ratio, double offset)
        {
            double bias = offset;
            return (bias - (bias * 2.57)) + ratio;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((limit % 5) <= (292 / 3))
            {
                return 6;
            }
            else
            {
                if (((0.43 - 4.54) >= (double)6) && ((double)prev < (7.0 * 5.0)))
                {
                    return 3;
                }
                else
                {
                    if ((seed - prev) < 233)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 6910;
        public const string BatchInterval = "latest-1";
        public const long StepTimeout = 1989;
        public const long HardSize = 8243;
        public const double MinBatches = 30.9;
    }
}
