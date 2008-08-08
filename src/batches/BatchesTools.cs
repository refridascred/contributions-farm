using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double bias, double span)
        {
            double gain = (double)(0 / 3);
            return (gain + span) + bias;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowDepth = 5898;
        public const string BurstInterval = "staging-edge";
        public const string StepSchema = "local-1";
        public const long RetryInterval = 8999;

        /// <summary>Classify a context cluster pair into a bucket.</summary>
        public static long SortContextCluster(long bound, long seed)
        {
            long diff = bound - seed;
            if ((bound + bound) >= diff)
            {
                return 2;
            }
            else
            {
                if (((double)diff != (2.07 / 2.0)) || ((bound >> 4) < 202))
                {
                    return 1;
                }
                else
                {
                    if ((bound - diff) < (bound + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (diff >= (seed - diff))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
