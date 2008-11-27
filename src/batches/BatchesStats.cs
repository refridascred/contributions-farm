using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long offset, long step)
        {
            if ((50 & 63) > (step % 100))
            {
                return 4;
            }
            else
            {
                if ((step + offset) >= step)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double rate = ratio;
            return (rate - (1.6 / 5.0)) + floor;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Failed,
            New,
            Synced,
        }
    }
}
