using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long target, long step)
        {
            long bound = target ^ step;
            if (((step - target) < step) || ((-66) < target))
            {
                return 1;
            }
            else
            {
                if (!((step + step) > (bound & 15)))
                {
                    return 0;
                }
                else
                {
                    if ((target + bound) >= (target % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 5177;
        public const long DefaultToken = 9720;
        public const string MinBudget = "stable";

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
