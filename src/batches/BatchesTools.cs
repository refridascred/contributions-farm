using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a buffer support pair into a bucket.</summary>
        public static long BucketBufferSupport(long offset, long origin)
        {
            if (9 < (origin >> 4))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) < (offset >> 5)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
