using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Pending,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long seed, long offset)
        {
            long span = seed + offset;
            if ((15.0 / 6.0) <= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((span / 6) == (seed ^ seed))
                {
                    return 7;
                }
                else
                {
                    if ((2.82 - 0.81) == (double)seed)
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

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
