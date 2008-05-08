using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double bias = span;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (bias - 8.0)) + (double)(long)i) + weight;
            }
            return bias - (double)3;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 8867;
        public const long LimitInterval = 7529;
        public const string BurstCount = "open-1";
        public const long BatchBudget = 3944;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long offset2)
        {
            long next = offset ^ offset2;
            if ((234 + offset) < (next / 6))
            {
                return 3;
            }
            else
            {
                if (next < (next * 5))
                {
                    return 7;
                }
                else
                {
                    if ((offset2 * 4) < (offset2 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((0.2 + 12.0) <= (double)offset2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
