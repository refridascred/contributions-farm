using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Classify a queue context pair into a bucket.</summary>
        public static long BucketQueueContext(long step, long seed)
        {
            long span = step - seed;
            if (step >= (step - span))
            {
                return 0;
            }
            else
            {
                if ((double)seed > (3.0 * 20.0))
                {
                    return 2;
                }
                else
                {
                    if ((1.9 + 9.4) >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step ^ seed) > (step ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "fallback-1";
        public const long MaxBudget = 3236;
        public const long BaseRatio = 4115;
    }
}
